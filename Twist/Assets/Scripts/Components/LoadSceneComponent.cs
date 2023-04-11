using UnityEngine;
using UnityEngine.Events;
using IJunior.TypedScenes;
using System.Collections;
using Assets.Scripts.Model;

namespace Assets.Scripts.Components
{
    public class LoadSceneComponent : MonoBehaviour 
    {
        [Space][Header("Animation Transite Settings")]
        public Animator animationTransitScene;
        public float transitionTime;//Time delay for animation

        [Space][Header("Loaded Scene")]
        public string sceneName;
        public bool isLoadSession;

        public void OnLoadScene()
        {
            if (!isLoadSession)
                StartCoroutine(LoadSceneAnimationtransite(sceneName));
            else
            {
                PlayerData sceneName = SaveLoadCurentData.LoadLastSession();
                StartCoroutine(LoadSceneAnimationtransite(sceneName.lastUsedLevel));
            }

        }

        
       IEnumerator LoadSceneAnimationtransite(string nextSceneLoad)
        {
            animationTransitScene.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);


            switch (nextSceneLoad)// crutch xD
            {
                case "Menu":
                    Menu.Load();
                    break;
                case "Bloc1_Level1":
                    Bloc1_Level1.Load();
                    break;
                case "Bloc1_Level2":
                    Bloc1_Level2.Load();
                    break;
                case "Bloc1_Level3":
                    Bloc1_Level3.Load();
                    break;
                default:
                    break;
            }
        }
    }
}
