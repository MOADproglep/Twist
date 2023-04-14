using UnityEngine;

namespace Assets.Scripts.Components
{
    public class DontDestroy : MonoBehaviour
    {
        public void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
