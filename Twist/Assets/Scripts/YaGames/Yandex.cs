using UnityEngine;
using System.Runtime.InteropServices;

namespace Assets.Scripts.YaGames
{
    public class Yandex : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void RateGame();
        [DllImport("__Internal")]
        private static extern void YaAdFullScreen();


        public void ViewRategame()
        {
            RateGame();
        }

        public void ViewAd()
        {
            YaAdFullScreen();
        }
    }
}
