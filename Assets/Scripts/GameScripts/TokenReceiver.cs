using UnityEngine;
using System;
using System.Web;
using Assets.Scripts.GameScripts;

public class TokenReceiver : MonoBehaviour
{
    void Start()
    {
        string url = Application.absoluteURL;
        if (!string.IsNullOrEmpty(url))
        {
            Uri uri = new Uri(url);
            var queryParams = HttpUtility.ParseQueryString(uri.Query);
            string token = queryParams.Get("token");

            if (!string.IsNullOrEmpty(token))
            {
                PlayerPrefs.SetString("jwt", token);
                Debug.Log("Token received from URL: " + token);
            }
            else
            {
                Debug.LogWarning("Token not found in URL.");
            }

            var profileManager = FindObjectOfType<ProfileManager>();
            if (profileManager != null)
            {
                profileManager.FetchProfile(token);
            }
        }
    }
}
