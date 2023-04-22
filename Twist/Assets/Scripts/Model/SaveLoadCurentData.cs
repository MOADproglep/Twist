using Assets.Scripts.Components;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Model
{
    public class SaveLoadCurentData : MonoBehaviour
    {
        private string _currentLevel;

        [NonSerialized]public bool muteMusicRecord;
        private LoadSceneComponent _nextLevel;


        private void Awake()
        {
            if(LoadLastSession() == null)
            {
                _nextLevel = GetComponent<LoadSceneComponent>();
                _currentLevel = _nextLevel.sceneName;
                muteMusicRecord = false;
                SaveCurrentSession();
            }
            else
            {
                _nextLevel = GetComponent<LoadSceneComponent>();
                _currentLevel = _nextLevel.sceneName;
            }
            //_nextLevel = GetComponent<LoadSceneComponent>();
            //_currentLevel = _nextLevel.sceneName;
            //_currentLevel = SceneManager.GetActiveScene().name;
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
