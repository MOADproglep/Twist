using UnityEngine;
using Assets.Components;
using UnityEditor.SceneManagement;

namespace Assets.Scripts
{
    public class InputReader : MonoBehaviour
    {
        private ReloadLevelComponent reloadLevel = new ReloadLevelComponent();

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
               reloadLevel.Reload();
            }
        }
    }
}
