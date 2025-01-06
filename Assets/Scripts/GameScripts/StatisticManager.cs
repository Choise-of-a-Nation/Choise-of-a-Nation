using Assets.Scripts.Clasess;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class StatisticManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        public Text desc;
        
        public void ShowPidtr()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Отримуємо ID сцени
            int sceneID = currentScene.buildIndex;
            int idLev = 0;
            int idCount = PlayerPrefs.GetInt("Country");


            Game game = load.LoadPlayersInfo();
            if (game.Levels[idLev].CountriesOpen[idCount].Parametrs[0].Value > 90)
            {
                game.Levels[idLev].CountriesOpen[idCount].Parametrs[0].Value = 90;
            }
            if (game.Levels[idLev].CountriesOpen[idCount].Parametrs[1].Value > 90)
            {
                game.Levels[idLev].CountriesOpen[idCount].Parametrs[1].Value = 90;
            }
            if (game.Levels[idLev].CountriesOpen[idCount].Parametrs[2].Value > 90)
            {
                game.Levels[idLev].CountriesOpen[idCount].Parametrs[2].Value = 90;
            }
            save.SavePlayers(game);
            desc.text = game.Levels[idLev].CountriesOpen[idCount].Parametrs[0].Value.ToString() + "% - " + game.Levels[idLev].CountriesOpen[idCount].Parametrs[0].Description + "\n\n" +
                        game.Levels[idLev].CountriesOpen[idCount].Parametrs[1].Value.ToString() + "% - " + game.Levels[idLev].CountriesOpen[idCount].Parametrs[1].Description + "\n\n" +
                        game.Levels[idLev].CountriesOpen[idCount].Parametrs[2].Value.ToString() + "% - " + game.Levels[idLev].CountriesOpen[idCount].Parametrs[2].Description + "\n\n";
        }

        public void ShowStanArmy()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Отримуємо ID сцени
            int sceneID = currentScene.buildIndex;
            int idLev = 0;
            int idCount = PlayerPrefs.GetInt("Country");

            Game game = load.LoadPlayersInfo();
            desc.text = game.Levels[idLev].CountriesOpen[idCount].Parametrs[3].Value.ToString() + "% - " + game.Levels[idLev].CountriesOpen[idCount].Parametrs[3].Description + "\n\n" +
                        game.Levels[idLev].CountriesOpen[idCount].Parametrs[5].Value.ToString() + " бійців - наша армія ";
        }

        public void ShowKazna()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            // Отримуємо ID сцени
            int sceneID = currentScene.buildIndex;
            int idLev = 0;
            int idCount = PlayerPrefs.GetInt("Country");

            Game game = load.LoadPlayersInfo();
            desc.text = game.Levels[idLev].CountriesOpen[idCount].Parametrs[4].Value.ToString() + " - " + game.Levels[idLev].CountriesOpen[idCount].Parametrs[4].Description;
        }

    }
}