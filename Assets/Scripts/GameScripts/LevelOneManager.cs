﻿using Assets.Scripts.Clasess;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
                }
                if (PlayerPrefs.GetString("WhoWin") == "enemy")
                {
                    PlayerPrefs.SetString("textLose", "На жаль ви програли, ваш вплив послабився. Цим скористалися вороги і опозиція, скинувши вас і захопивши владу.");
                    PlayerPrefs.SetString("textEngLose", "На жаль ви програли, ваш вплив послабився. Цим скористалися вороги і опозиція, скинувши вас і захопивши владу.");
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
        }

        public void BackSave()
        {
            save.SavePlayers(game);
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
                    PlayerPrefs.SetInt("OurOrg", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value / 100f) * 50)));
                    PlayerPrefs.SetInt("EnemyOrg", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[3].Value);
                    PlayerPrefs.SetInt("OurBoyDuh", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[1].Value / 100f) * 50)));
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
                SceneManager.LoadSceneAsync(4);
                PlayerPrefs.SetString("textWin", "Кінець Київської держави став завершенням величної епохи, яка залишила по собі незабутній слід в історії. Внутрішні чвари між князями, які не змогли об’єднатися перед обличчям зовнішньої загрози, та навала монгольських орд у 1240 році зруйнували основи колись могутньої держави. Київ, серце Русі, упав після облоги, і його величні храми й стіни перетворилися на попелище.\r\n\r\nПроте ця трагедія не означала остаточного кінця. Дух Київської Русі, її культура і віра, продовжили жити, перейшовши до нових центрів, таких як Володимиро-Суздальська земля та пізніше Московія. Русь не загинула — вона трансформувалася, залишивши світові урок про важливість єдності перед викликами часу.\r\n\r\nГра завершена. Але історія Київської держави надихає й досі.");
                PlayerPrefs.SetString("textWinEng", "The end of the Kievan Rus’ was the end of a great era that left an unforgettable mark on history. Internal strife between princes who could not unite in the face of an external threat, and the invasion of the Mongol hordes in 1240 destroyed the foundations of the once powerful state. Kiev, the heart of Rus’, fell after a siege, and its majestic temples and walls were reduced to ashes.\r\n\r\nHowever, this tragedy did not mean the final end. The spirit of Kievan Rus’, its culture and faith, continued to live on, moving to new centers, such as the Vladimir-Suzdal land and later Muscovy. Rus’ did not perish — it transformed, leaving the world a lesson about the importance of unity in the face of the challenges of time.\r\n\r\nThe game is over. But the history of the Kievan Rus’ is still inspiring.");
            }

            BackSave();
        }
    }
}