using Assets.Scripts.Clasess.Levels;
using Assets.Scripts.Clasess;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms.Impl;
using Assets.Scripts.Clasess.Profile;
using System.Text;
using System;

namespace Assets.Scripts.GameScripts
{
    public class AchiventmentsManager : MonoBehaviour
    {
        bool isOpen = false;
        Game game = new Game();
        Load load = new Load();
        Save save = new Save();

        public GameObject contentPar;
        public GameObject anchivPr;
        Text[] texts = new Text[] { };

        Text nameAch;
        Text descAch;
        Text isOkAch;
        RawImage imgAch;

        private string updateUrl = "https://choiseofanation.tryasp.net/register/get-achiv-is-ok/";

        void Start()
        {
            
        }

        public void Open()
        {
            isOpen = true;
            game = load.LoadStartInfo(); 
            if (game == null || game.Levels == null)
            {
                Debug.LogError("Game data is null!");
                return;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (isOpen)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }

                for (int i = 0; i < game.Achievements.Count; i++)
                {
                    StartCoroutine(GetIsOkAchiv(PlayerPrefs.GetString("token"), PlayerPrefs.GetString("id-user"), game.Achievements[i], i));
                }

                isOpen = false;
            }
        }

        public void GetIsOk(string token, string userId, Achievements achievement)
        {
            StartCoroutine(GetIsOkAchiv(token, userId, achievement, achievement.Id));
        }

        IEnumerator GetIsOkAchiv(string token, string userId, Achievements achievement, int index)
        {
            UnityWebRequest request = new UnityWebRequest($"{updateUrl}{userId}", "POST");
            byte[] bodyRaw = Encoding.UTF8.GetBytes($"\"{achievement.Name}\"");
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + token);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("✅ isOk отримано: " + request.downloadHandler.text);
                achievement.isOk = request.downloadHandler.text == "true";
            }
            else
            {
                Debug.LogError("❌ Помилка при отриманні: " + request.error + " | " + request.downloadHandler.text);
                achievement.isOk = false;
            }

            // Створення UI після отримання відповіді
            GameObject curEff = Instantiate(anchivPr, contentPar.transform);
            curEff.transform.position = new Vector3(curEff.transform.position.x - (2 * index), curEff.transform.position.y, curEff.transform.position.z);

            texts = curEff.GetComponentsInChildren<Text>();
            foreach (Text text in texts)
            {
                if (text.name == "Name")
                    nameAch = text;
                if (text.name == "Description")
                    descAch = text;
                if (text.name == "isOk")
                    isOkAch = text;
            }

            nameAch.GetComponent<TextLanguage>().textUkr = achievement.Name;
            nameAch.GetComponent<TextLanguage>().textEng = achievement.NameEng;
            nameAch.text = achievement.Name;

            descAch.GetComponent<TextLanguage>().textUkr = achievement.Description;
            descAch.GetComponent<TextLanguage>().textEng = achievement.DescriptionEng;
            descAch.text = achievement.Description;

            if (achievement.isOk)
            {
                isOkAch.GetComponent<TextLanguage>().textUkr = "Отримано";
                isOkAch.GetComponent<TextLanguage>().textEng = "Received";
                isOkAch.text = "Отримано";
            }
            else
            {
                isOkAch.GetComponent<TextLanguage>().textUkr = "Не отримано";
                isOkAch.GetComponent<TextLanguage>().textEng = "Not received";
                isOkAch.text = "Не отримано";
            }

            imgAch = curEff.GetComponentInChildren<RawImage>();
            LoadImage(achievement, imgAch);
        }


        void LoadImage(Achievements ach, RawImage img)
        {
            if (!string.IsNullOrEmpty(ach.IconUrl))
            {
                StartCoroutine(DownloadImage(ach.IconUrl, img));
            }
            else
            {
                Debug.LogWarning("URL зображення порожній.");
            }
        }

        IEnumerator DownloadImage(string url, RawImage img)
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

                if (img == null)
                {
                    Debug.LogError("❌ Фото або її testure-компонент не призначено!");
                    yield break;
                }
                img.texture = texture;
            }
            else
            {
                Debug.LogError("❌ Не вдалося завантажити зображення: " + request.error);
            }
        }

        [Serializable]
        public class UpdateAchivsDTO
        {
            public int Id;
            public string Name;
            public string NameEng;
            public string Description;
            public string DescriptionEng;
            public string IconUrl;
            public bool isOk;
        }
    }
}