using System.Runtime.InteropServices;
using UnityEngine;

namespace Assets.Scripts.YaGames
{
    public class Language : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern string GetLang();


        public string CurrentLanguage;
        public static Language Instanse;


        private void Awake()
        {
            if ( Instanse == null ) 
            {
                Instanse = this;
                DontDestroyOnLoad(gameObject);

                CurrentLanguage = GetLang();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
