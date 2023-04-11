using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Model
{
    public class SaveLoadCurentData : MonoBehaviour
    {
        private string _currentLevel;
        public bool muteMusicRecord;

        private void Awake()
        {
            _currentLevel = SceneManager.GetActiveScene().name;
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
