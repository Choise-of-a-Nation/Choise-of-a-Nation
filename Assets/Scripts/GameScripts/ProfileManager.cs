using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Profile;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class ProfileManager : MonoBehaviour
    {
        private string profileUrl = "https://choiseofanation.tryasp.net/register/get-user/";
        Load load = new Load();
        Save save = new Save();
        Game game;

        public Button prBut;
        public RawImage logo;
        public Text nameTxt;
        public Text emailTxt;
        public Text plHoursTxt;

        private void Start()
        {
            game = load.LoadStartInfo();
        }

        public void FetchProfile(string token)
        {
            Debug.Log("Отримано токен у ProfileManager. Старт декодування...");
            string userId = ExtractUserIdFromToken(token);
            PlayerPrefs.SetString("token", token);
            PlayerPrefs.SetString("id-user", userId);

            if (!string.IsNullOrEmpty(userId))
            {
                Debug.Log("Витягнутий userId з токена: " + userId);
                StartCoroutine(GetUserProfile(userId, token));
            }
            else
            {
                Debug.LogError("❌ Не вдалося витягти userId з токена");
            }
        }

        IEnumerator GetUserProfile(string userId, string token)
        {
            string url = profileUrl + userId;
            UnityWebRequest request = UnityWebRequest.Get(url);
            request.SetRequestHeader("Authorization", "Bearer " + token);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("✅ Отримані дані профілю: " + request.downloadHandler.text);
                Player newPl = JsonConvert.DeserializeObject<Player>(request.downloadHandler.text);
                Debug.Log("Email: " + newPl.Email);
                game.PlayerData = newPl;
                save.SaveStartGame(game);
                LoadImageFromPlayer(game.PlayerData);
                nameTxt.text = "Ім'я " + newPl.FirstName + " " + newPl.LastName;
                emailTxt.text = "Пошта " + newPl.Email;
                plHoursTxt.text = "Кількість зіграних годин " + ((float)newPl.PlayedHours / 3600 / 3600 / 60).ToString();
            }
            else
            {
                Debug.LogError("❌ Помилка отримання профілю: " + request.error);
            }
        }

        public void LoadImageFromPlayer(Player player)
        {
            if (!string.IsNullOrEmpty(player.Url))
            {
                StartCoroutine(DownloadImage(player.Url));
            }
            else
            {
                Debug.LogWarning("URL зображення порожній.");
            }
        }

        IEnumerator DownloadImage(string url)
        {
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture = DownloadHandlerTexture.GetContent(request);

                if (texture == null || texture.width == 0 || texture.height == 0)
                {
                    Debug.LogError("❌ Завантажено пошкоджену або порожню текстуру.");
                    yield break;
                }

                Sprite sprite = Sprite.Create(
                    texture,
                    new Rect(0, 0, texture.width, texture.height),
                    new Vector2(0.5f, 0.5f)
                );

                if (prBut == null || prBut.image == null)
                {
                    Debug.LogError("❌ Кнопка або її Image-компонент не призначено!");
                    yield break;
                }

                prBut.image.sprite = sprite;
                logo.texture = texture;
            }
            else
            {
                Debug.LogError("❌ Не вдалося завантажити зображення: " + request.error);
            }
        }

        private string ExtractUserIdFromToken(string token)
        {
            try
            {
                string[] parts = token.Split('.');
                if (parts.Length != 3)
                {
                    Debug.LogError("❌ Невірний формат JWT токена");
                    return null;
                }

                string payload = parts[1];
                payload = payload.Replace('-', '+').Replace('_', '/');
                switch (payload.Length % 4)
                {
                    case 2: payload += "=="; break;
                    case 3: payload += "="; break;
                    case 1: payload += "==="; break;
                }

                byte[] bytes = Convert.FromBase64String(payload);
                string json = Encoding.UTF8.GetString(bytes);

                JwtPayload payloadData = JsonUtility.FromJson<JwtPayload>(json);
                return payloadData.UserId;
            }
            catch (Exception ex)
            {
                Debug.LogError("❌ Помилка при декодуванні токена: " + ex.Message);
                return null;
            }
        }

        [Serializable]
        private class JwtPayload
        {
            public string UserId;
        }
    }
}