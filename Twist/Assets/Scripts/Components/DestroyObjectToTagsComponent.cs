using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Components
{
    public class DestroyObjectToTagsComponent : MonoBehaviour
    {
        [SerializeField] private string[] _tag;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            for (int i = 0; i < _tag.Length; i++)
            {
                if (collision.gameObject.CompareTag(_tag[i]))
                {
                    Destroy(gameObject);
                }
            }    
        }
    }
}
