using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Components
{
    public class EnterCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string[] _tag;
        [SerializeField] private UnityEvent<GameObject> _action;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            for (int i = 0; i < _tag.Length; i++)
            {
                if (collision.gameObject.CompareTag(_tag[i]))
                {
                    _action?.Invoke(collision.gameObject);
                }
            }
        }
    }
}
