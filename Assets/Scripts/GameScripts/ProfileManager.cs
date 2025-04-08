using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.GameScripts
{
    public class ProfileManager : MonoBehaviour
    {
        private string profileUrl = "https://choiseofanation.tryasp.net/register/get-user/";

        public void FetchProfile(string token)
        {
            Debug.Log("Отримано токен у ProfileManager. Старт декодування...");
            string userId = ExtractUserIdFromToken(token);

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
            }
            else
            {
                Debug.LogError("❌ Помилка отримання профілю: " + request.error);
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