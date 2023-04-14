using Assets.Scripts.Components;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Model
{
    public class SaveLoadCurentData : MonoBehaviour
    {
        public static bool muteMusicRecord;

        private string _currentLevel;
        //private int _indexCurrentScene;

        private LoadSceneComponent _nextLevel;


        private void Awake()
        {
            if(LoadLastSession() == null)
            {
                _nextLevel = GetComponent<LoadSceneComponent>();
                _currentLevel = _nextLevel.sceneName;
                muteMusicRecord = false;
                SaveCurrentSession();
                Debug.Log("SaveLoad");
            }
            else
            {
                _nextLevel = GetComponent<LoadSceneComponent>();
                _currentLevel = _nextLevel.sceneName;
            }
            //_nextLevel = GetComponent<LoadSceneComponent>();
            //_currentLevel = _nextLevel.sceneName;
            //_currentLevel = SceneManager.GetActiveScene().name;
            
            //_indexCurrentScene = SceneManager.GetActiveScene().buildIndex;
            //_currentLevel = SceneManager.GetSceneByBuildIndex(_indexCurrentScene + 1).name; //Load next scene
            //Debug.Log($"{_indexCurrentScene} , {_currentLevel}");
        }
        public void SaveCurrentSession()
        {
            GameSession.SaveSession(_currentLevel, muteMusicRecord);
        }

        public static PlayerData LoadLastSession()
        {
            PlayerData data = GameSession.LoadDataSession();

            return data;
        }
    }
}
