using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
       public static GameManager instance;
        public int score = 0;
        private string CurrentLevelName = string.Empty;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;

                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
                Debug.LogError("Trying to instantiate a second" + "isntance of singleton Game Manager");
            }
        }

        public void LoadLevel(string levelName)
        {
            AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

            if (ao != null) {
                Debug.LogError("[GameManager] Unable to Load Level " + levelName);
                return;
            }
            CurrentLevelName = levelName;
        }

        public void unloadlevel(string levelName)
        {
            AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

            if (ao != null)
            {
                Debug.LogError("[GameManager] Unable to unLoad Level " + levelName);
                return;
            }
        }
    }
}