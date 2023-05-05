using UnityEngine;
using Assets.Components;
using Assets.Scripts.Components;

namespace Assets.Scripts
{
    public class InputReader : MonoBehaviour 
    {
        private ReloadLevelComponent _reloadLevel;

        private void Awake()
        {
            _reloadLevel = GetComponent<ReloadLevelComponent>();
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                _reloadLevel.Reload();
            }
        }
    }
}
