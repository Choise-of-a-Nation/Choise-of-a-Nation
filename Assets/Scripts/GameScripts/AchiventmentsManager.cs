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
                    GameObject curEff = Instantiate(anchivPr, contentPar.transform);
                    curEff.transform.position = new Vector3(curEff.transform.position.x - (2 * i), curEff.transform.position.y, curEff.transform.position.z);

                    texts = curEff.GetComponentsInChildren<Text>();
                    foreach (Text text in texts)
                    {
                        if (text.name == "Name")
                        {
                            nameAch = text;
                        }
                        if (text.name == "Description")
                        {
                            descAch = text;
                        }
                        if (text.name == "isOk")
                        {
                            isOkAch = text;
                        }
                    }

                    nameAch.GetComponent<TextLanguage>().textUkr = game.Achievements[i].Name;
                    nameAch.GetComponent<TextLanguage>().textEng = game.Achievements[i].NameEng;
                    nameAch.text = game.Achievements[i].Name;
                    descAch.GetComponent<TextLanguage>().textUkr = game.Achievements[i].Description;
                    descAch.GetComponent<TextLanguage>().textEng = game.Achievements[i].DescriptionEng;
                    descAch.text = game.Achievements[i].Description;

                    if (game.Achievements[i].isOk)
                    {
                        isOkAch.GetComponent<TextLanguage>().textUkr = "Отримано";
                        isOkAch.GetComponent<TextLanguage>().textEng = "Received";
                        isOkAch.text = "Отримано";
                    }
                    if (!game.Achievements[i].isOk)
                    {
                        isOkAch.GetComponent<TextLanguage>().textUkr = "Не отримано";
                        isOkAch.GetComponent<TextLanguage>().textEng = "Not received";
                        isOkAch.text = "Не отримано";
                    }

                    imgAch = curEff.GetComponentInChildren<RawImage>();
                    LoadImage(game.Achievements[i], imgAch);
                }
                isOpen = false;
            }
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
    }
}