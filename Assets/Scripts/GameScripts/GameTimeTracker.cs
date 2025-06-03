using UnityEngine;

namespace Assets.Scripts.GameScripts
{
    public class GameTimeTracker : MonoBehaviour
    {
        public static GameTimeTracker Instance { get; private set; }

        private float sessionStartTime;
        public int TotalPlayedSeconds { get; private set; }

        private void Awake()
        {
            // Singleton Pattern
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject); // Не знищується при зміні сцен

            sessionStartTime = Time.realtimeSinceStartup;
        }

        public void SaveSessionTime()
        {
            float played = Time.realtimeSinceStartup - sessionStartTime;
            if (played > 0)
                TotalPlayedSeconds += Mathf.FloorToInt(played);

            sessionStartTime = Time.realtimeSinceStartup; // Перезапуск для наступного відліку
        }

        public int GetTotalPlayedHours()
        {
            return Mathf.FloorToInt(TotalPlayedSeconds / 3600f);
        }
    }

}
