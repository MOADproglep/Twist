using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class OutputLevelNameComponent : MonoBehaviour
    {
        public TMP_Text _text;
        private void Update()
        {
            _text.text = SceneManager.GetActiveScene().name;
        }
    }
}
