using Assets.Scripts.Clasess;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Menu
{
    public class MenuScript : MonoBehaviour
    {
        public void Play(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }

        public void Exit()
        {
            #if UNITY_WEBGL
            // Для WebGL — просто перехід на інший сайт або повідомлення
            Debug.Log("Exit не підтримується у WebGL");
            Application.OpenURL("https://choiseoda-nation-frontend.vercel.app/"); // Наприклад, головна сторінка
            #else
            // Для всіх інших платформ — стандартний вихід
            Application.Quit();
            #endif
        }
    }
}