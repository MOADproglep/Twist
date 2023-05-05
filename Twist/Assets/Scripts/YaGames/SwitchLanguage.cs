using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.YaGames
{
    public class SwitchLanguage : MonoBehaviour
    {
        [SerializeField] private UnityEvent<GameObject> _RU;
        [SerializeField] private UnityEvent<GameObject> _EN;
        private void Start()
        {
            if(Language.Instanse.CurrentLanguage == "ru") 
            {
                _RU?.Invoke(gameObject);
            }
            else if (Language.Instanse.CurrentLanguage == "en")
            {
                _EN?.Invoke(gameObject);
            }
            else
            {
                _RU?.Invoke(gameObject);
            }
        }
    }
}
