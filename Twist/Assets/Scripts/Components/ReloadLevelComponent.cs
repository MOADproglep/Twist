using IJunior.TypedScenes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Components
{
    public class ReloadLevelComponent : MonoBehaviour
    {
        public void Reload()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
