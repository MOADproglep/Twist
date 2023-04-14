using Assets.Scripts.Model;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Sound
{

    public class SoundManager : MonoBehaviour
    {
        private bool _isPlaying = true;
        private GameObject _soundSourseInScene;
        private AudioSource _audioSource;

        public Sprite onSoundImage;
        public Sprite offSoundImage;
        public Button button;


        private void Awake()
        {
            
            _soundSourseInScene = GameObject.Find("SoundObject");
            _audioSource = _soundSourseInScene.GetComponent<AudioSource>();
        }

        private void Start()
        {
            PlayerData data = SaveLoadCurentData.LoadLastSession();
            if (data != null && data.muteMusic)
            {
                button.image.sprite = onSoundImage;
                _isPlaying = true;
                _audioSource.Play();
                Debug.Log("Play");
            }
            else if (data != null && !data.muteMusic)
            {
                button.image.sprite = offSoundImage;
                _isPlaying = false;
            }
        }

        public void SelectedMute()
        {
            if (_isPlaying)
            {
                _audioSource.Stop();
                button.image.sprite = offSoundImage;
                SaveLoadCurentData.muteMusicRecord = true;
                _isPlaying = false;
            }
            else
            {
                _audioSource.Play();
                button.image.sprite = onSoundImage;
                SaveLoadCurentData.muteMusicRecord = false;
                _isPlaying = true;
            }
        }
        //public SoundAudioClip[] soundAudioClipsArray;

        //public enum SoundClip
        //{
        //    BallDestroy,
        //    BallWin,
        //    StartGame
        //}

        //[System.Serializable]
        //public class SoundAudioClip
        //{
        //    public SoundClip sound;
        //    public AudioClip audioClip;
        //}

        //public void PlaySound(string nameClip)
        //{
        //    foreach(var clip in soundAudioClipsArray)
        //    {
        //        //if(clip.sound = nameClip)
        //        //{

        //        //}
        //        ////if(s)
        //        ////AudioSource audioSource = new AudioSource();
        //        ////audioSource.PlayOneShot()
        //    }
        //}



    }
}
