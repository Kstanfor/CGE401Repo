using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



    public class GameManager : Singleton<GameManager>
    {
      
        public int score = 0;

        public GameObject pauseMenu;

        private string currentLevelName = string.Empty;

        /*public static GameManager instance;
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
        }*/

        public void LoadLevel(string levelName)
        {
            AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

            if (ao != null) {
                Debug.LogError("[GameManager] Unable to Load Level " + levelName);
                return;
            }
            currentLevelName = levelName;
        }

       /* public void Unloadlevel(string levelName)
        {
            AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

            if (ao != null)
            {
                Debug.LogError("[GameManager] Unable to unLoad Level " + levelName);
                return;
            }
        }*/

        public void UnloadCurrentLevel()
        {
            AsyncOperation ao = SceneManager.UnloadSceneAsync(currentLevelName);

            if (ao != null)
            {
                Debug.LogError("[GameManager] Unable to unLoad Level " + currentLevelName);
                return;
            }
           
        }

        public void Pause()
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
        public void Unpause()
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P)) 
            {
                Pause();
            }
        }
    }
