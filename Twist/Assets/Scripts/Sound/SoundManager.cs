using Assets.Scripts.Model;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Sound
{

    public class SoundManager : MonoBehaviour
    {
        private bool _isPlaying;
        private GameObject _soundSourseInScene;
        private GameObject _LevelLoadedandSave;
        private AudioSource _audioSource;
        private SaveLoadCurentData _saveLoadCurentData;

        public Sprite onSoundImage;
        public Sprite offSoundImage;
        public Button button;

        public AudioClip[] audioClips;


        private void Awake()
        {
            _soundSourseInScene = GameObject.Find("SoundObject");
            _audioSource = _soundSourseInScene.GetComponent<AudioSource>();

            _LevelLoadedandSave = GameObject.Find("LevelLoadedandSave");
            _saveLoadCurentData = _LevelLoadedandSave.GetComponent<SaveLoadCurentData>();
        }

        private void Start()
        {
            PlayerData data = SaveLoadCurentData.LoadLastSession();
            if (data != null && !data.muteMusic)
            {
                button.image.sprite = onSoundImage;
                _isPlaying = true;

                if(!_audioSource.isPlaying)
                    _audioSource.Play();

                _saveLoadCurentData.muteMusicRecord = false;
            }
            else if (data != null && data.muteMusic)
            {
                button.image.sprite = offSoundImage;
                _isPlaying = false;
                _audioSource.Stop();
                _saveLoadCurentData.muteMusicRecord = true;
            }
        }

        public void SelectedMute()
        {
            if (_isPlaying)
            {
                _audioSource.Stop();
                button.image.sprite = offSoundImage;
                _isPlaying = false;

                _saveLoadCurentData.muteMusicRecord = true;
                _saveLoadCurentData.SaveCurrentSession();
            }
            else
            {
                _audioSource.Play();
                button.image.sprite = onSoundImage;
                _isPlaying = true;

                _saveLoadCurentData.muteMusicRecord = false;
                _saveLoadCurentData.SaveCurrentSession();
            }
        }

        public void OnPlayButtonClip()
        {
            if (_isPlaying) _audioSource.PlayOneShot(audioClips[0]);
        }
        public void OnPlayDeathClip()
        {
            if (_isPlaying) _audioSource.PlayOneShot(audioClips[1]);
        }
        public void OnPlayWinClip()
        {
            if (_isPlaying) _audioSource.PlayOneShot(audioClips[2]);
        }
        public void OnPlayPistonClip()
        {
            if (_isPlaying) _audioSource.PlayOneShot(audioClips[3]);
        }
    }
}
