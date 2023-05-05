using UnityEngine;

namespace Assets.Scripts.YaGames
{
    public class ShowAd : MonoBehaviour
    {
        private void Start()
        {
            Yandex yandex = new Yandex();
            yandex.ViewAd();
        }
    }
}
