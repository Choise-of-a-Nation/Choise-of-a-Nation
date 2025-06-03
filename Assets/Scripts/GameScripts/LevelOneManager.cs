using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Profile;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static Assets.Scripts.GameScripts.AchiventmentsManager;

namespace Assets.Scripts.GameScripts
{
    public class LevelOneManager : MonoBehaviour
    {
        #region Statistice
        Load load = new Load();
        Save save = new Save();

        Game game = new Game();

        public Text pidtr;
        public Text stanArmy;
        public Text kazna;
        #endregion

        public Text textContent;
        public GameObject panelChoises;

        int idText = 0;
        int idTurn = 0;

        private string updateUrl = "https://choiseofanation.tryasp.net/register/update-hours/";
        private string updateUrlAchiv = "https://choiseofanation.tryasp.net/register/update-achivs/";

        // Use this for initialization
        void Start()
        {
            game = load.LoadPlayersInfo();

            if (game.Levels[0].CountriesOpen[0].IdTurnCur != 0)
            {
                idTurn = game.Levels[0].CountriesOpen[0].IdTurnCur;

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn].IdTextCur != 0)
                {
                    idText = game.Levels[0].CountriesOpen[0].Turns[idTurn].IdTextCur;
                }
            }

            PlayerPrefs.SetInt("EnterChoise", -1);

            pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
            stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
            kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();

            textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;
        }

        // Update is called once per frame
        void Update()
        {
            if (PlayerPrefs.GetString("WhoWin") != null || PlayerPrefs.GetString("WhoWin") != "")
            {
                if (PlayerPrefs.GetString("WhoWin") == "our")
                {
                    idTurn += 1;
                    idText = 0;

                    textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                    textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                    textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;

                    if (!game.Achievements[0].isOk)
                    {
                        game.Achievements[0].isOk = true;
                        BackSave();
                        SendUpdateAchiv(game.Achievements[0], PlayerPrefs.GetString("token"), PlayerPrefs.GetString("id-user"));
                        Debug.Log("Achiv: " + game.Achievements[0].Name);
                    }
                }
                if (PlayerPrefs.GetString("WhoWin") == "enemy")
                {
                    if (!game.Achievements[1].isOk)
                    {
                        game.Achievements[1].isOk = true;
                        BackSave();
                        SendUpdateAchiv(game.Achievements[0], PlayerPrefs.GetString("token"), PlayerPrefs.GetString("id-user"));
                        Debug.Log("Achiv: " + game.Achievements[1].Name);
                    }

                    PlayerPrefs.SetString("textLose", "На жаль ви програли, ваш вплив послабився. Цим скористалися вороги і опозиція, скинувши вас, захопила владу.");
                    PlayerPrefs.SetString("textEngLose", "Unfortunately, you lost, your influence weakened. Your enemies and the opposition took advantage of this, overthrowing you and seizing power.");
                    SceneManager.LoadSceneAsync(3);
                }

                PlayerPrefs.SetString("WhoWin", "");
            }

            if (PlayerPrefs.GetInt("EnterChoise") != -1)
            {
                panelChoises.gameObject.SetActive(false);
                for (int i = 0; i < game.Levels[0].CountriesOpen[0].Parametrs.Count; i++)
                {
                    Debug.Log(PlayerPrefs.GetInt("EnterChoise"));
                    Debug.Log(PlayerPrefs.GetInt("Turn"));
                    for (int j = 0; j < game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result.Count; j++)
                    {
                        if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result[j].Name)
                        {
                            game.Levels[0].CountriesOpen[0].Parametrs[i].Value += game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result[j].Value;
                        }
                    }
                }

                pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
                stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
                kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();
                BackSave();
                PlayerPrefs.SetInt("EnterChoise", -1);
            }

            pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
            stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
            kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();
        }

        public void BackSave()
        {
            save.SavePlayers(game);
            SendPlayedTime(game.PlayerData.PlayedHours, PlayerPrefs.GetString("token"), PlayerPrefs.GetString("id-user"));
        }

        public void SendPlayedTime(int addedHours, string token, string userId)
        {
            UpdateHoursRequest requestData = new UpdateHoursRequest
            {
                AddedHours = addedHours
            };

            string json = JsonUtility.ToJson(requestData);
            StartCoroutine(PostPlayedHours(json, token, userId));
        }

        IEnumerator PostPlayedHours(string json, string token, string userId)
        {
            UnityWebRequest request = new UnityWebRequest(updateUrl + userId, "POST");
            byte[] bodyRaw = Encoding.UTF8.GetBytes(json);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + token);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("✅ Години успішно оновлено: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("❌ Помилка при оновленні годин: " + request.error + " | " + request.downloadHandler.text);
            }
        }

        public void SendUpdateAchiv(Achievements achievement, string token, string userId)
        {
            UpdateAchivsDTO requestData = new UpdateAchivsDTO
            {
                Id = achievement.Id,
                Name = achievement.Name,
                NameEng = achievement.NameEng,
                Description = achievement.Description,
                DescriptionEng = achievement.DescriptionEng,
                IconUrl = achievement.IconUrl,
                isOk = achievement.isOk
            };

            string json = JsonUtility.ToJson(requestData);
            StartCoroutine(PostAchiv(json, token, userId));
        }

        IEnumerator PostAchiv(string json, string token, string userId)
        {
            UnityWebRequest request = new UnityWebRequest(updateUrlAchiv + userId, "POST");
            byte[] bodyRaw = Encoding.UTF8.GetBytes(json);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + token);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("✅ Досягнення успішно оновлено: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("❌ Помилка при оновленні досягнень: " + request.error + " | " + request.downloadHandler.text);
            }
        }

        public void Back()
        {
            SceneManager.LoadSceneAsync(0);
        }

        public void NextText()
        {
            idText++;
            Debug.Log(idText);

            if (idText >= game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents.Count)
            {
                textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.Description;
                textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.Description;
                textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.DescriptionEng;

                idTurn++;
                idText = 0;

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[0].Name == "Бій")
                {
                    game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].IdTextCur = idText;
                    game.Levels[0].CountriesOpen[0].IdTurnCur = idTurn - 1;
                    PlayerPrefs.SetString("OurLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[4].Name);
                    PlayerPrefs.SetString("EnemyLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[5].Name);
                    PlayerPrefs.SetInt("OurArmy", game.Levels[0].CountriesOpen[0].Parametrs[5].Value);
                    PlayerPrefs.SetInt("EnemyArmy", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[1].Value);
                    PlayerPrefs.SetInt("OurOrg", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value / 100f) * game.Levels[0].CountriesOpen[0].Parametrs[3].Value)));
                    PlayerPrefs.SetInt("EnemyOrg", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[3].Value);
                    PlayerPrefs.SetInt("OurBoyDuh", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[1].Value / 100f) * game.Levels[0].CountriesOpen[0].Parametrs[3].Value)));
                    PlayerPrefs.SetInt("EnemyBoyDuh", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[2].Value);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Scene", 5);
                    SceneManager.LoadSceneAsync(2);
                    BackSave();
                }

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].Choises.Count > 0)
                {
                    panelChoises.gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Turn", idTurn - 1);
                }

                for (int i = 0; i < game.Levels[0].CountriesOpen[0].Parametrs.Count; i++)
                {
                    for (int j = 0; j < game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result.Count; j++)
                    {
                        if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Name)
                        {
                            if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == "Скарбниця")
                            {
                                game.Levels[0].CountriesOpen[0].Parametrs[i].Value += (10 + (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Value / 100) * game.Levels[0].CountriesOpen[0].Parametrs[2].Value);
                            }
                            game.Levels[0].CountriesOpen[0].Parametrs[i].Value += game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Value;
                        }
                    }
                }

                pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
                stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
                kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();
            }
            else
            {
                textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;
            }

            if (idTurn >= game.Levels[0].CountriesOpen[0].Turns.Count)
            {
                if (!game.Achievements[2].isOk)
                {
                    game.Achievements[2].isOk = true;
                    BackSave();
                    SendUpdateAchiv(game.Achievements[0], PlayerPrefs.GetString("token"), PlayerPrefs.GetString("id-user"));
                    Debug.Log("Achiv: " + game.Achievements[2].Name);
                }

                SceneManager.LoadSceneAsync(4);
                PlayerPrefs.SetString("textWin", "Кінець Київської держави став завершенням величної епохи, яка залишила по собі незабутній слід в історії. Внутрішні чвари між князями, які не змогли об’єднатися перед обличчям зовнішньої загрози, та навала монгольських орд у 1240 році зруйнували основи колись могутньої держави. Київ, серце Русі, упав після облоги, і його величні храми й стіни перетворилися на попелище.\r\n\r\nПроте ця трагедія не означала остаточного кінця. Дух Київської Русі, її культура і віра, продовжили жити, перейшовши до нових центрів, таких як Володимиро-Суздальська земля та пізніше Московія. Русь не загинула — вона трансформувалася, залишивши світові урок про важливість єдності перед викликами часу.\r\n\r\nГра завершена. Але історія Київської держави надихає й досі.");
                PlayerPrefs.SetString("textWinEng", "The end of the Kievan Rus’ was the end of a great era that left an unforgettable mark on history. Internal strife between princes who could not unite in the face of an external threat, and the invasion of the Mongol hordes in 1240 destroyed the foundations of the once powerful state. Kiev, the heart of Rus’, fell after a siege, and its majestic temples and walls were reduced to ashes.\r\n\r\nHowever, this tragedy did not mean the final end. The spirit of Kievan Rus’, its culture and faith, continued to live on, moving to new centers, such as the Vladimir-Suzdal land and later Muscovy. Rus’ did not perish — it transformed, leaving the world a lesson about the importance of unity in the face of the challenges of time.\r\n\r\nThe game is over. But the history of the Kievan Rus’ is still inspiring.");
            }

            GameTimeTracker.Instance.SaveSessionTime();
            game.PlayerData.PlayedHours = GameTimeTracker.Instance.GetTotalPlayedHours();
            Debug.Log(GameTimeTracker.Instance.GetTotalPlayedHours());

            BackSave();
        }

        public void EditInfluence(string nameBut)
        {
            if (game.Levels[0].CountriesOpen[0].Parametrs[4].Value > 100)
            {
                if (nameBut == "Elite")
                {
                    game.Levels[0].CountriesOpen[0].Parametrs[0].Value += 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[2].Value -= 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[4].Value -= 100;
                    Debug.Log("Click");
                }
                if (nameBut == "Army")
                {
                    game.Levels[0].CountriesOpen[0].Parametrs[1].Value += 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[0].Value -= 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[4].Value -= 100;
                }
                if (nameBut == "People")
                {
                    game.Levels[0].CountriesOpen[0].Parametrs[2].Value += 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[0].Value -= 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[4].Value -= 100;
                }
                if (nameBut == "Stan")
                {
                    game.Levels[0].CountriesOpen[0].Parametrs[3].Value += 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[0].Value -= 10;
                    game.Levels[0].CountriesOpen[0].Parametrs[4].Value -= 100;
                }
                if (nameBut == "Army")
                {
                    game.Levels[0].CountriesOpen[0].Parametrs[5].Value += 1000;
                    game.Levels[0].CountriesOpen[0].Parametrs[4].Value -= 100;
                }
            }

            BackSave();
        }

        [Serializable]
        public class UpdateHoursRequest
        {
            public int AddedHours;
        }
    }
}