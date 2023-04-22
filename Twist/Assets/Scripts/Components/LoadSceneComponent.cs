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
                case "Bloc1_Level4":
                    Bloc1_Level4.Load();
                    break;
                case "Bloc1_Level5":
                    Bloc1_Level5.Load();
                    break;
                case "Bloc1_Level6":
                    Bloc1_Level6.Load();
                    break;
                case "Bloc1_Level7":
                    Bloc1_Level7.Load();
                    break;
                case "Bloc1_Level8":
                    Bloc1_Level8.Load();
                    break;
                case "Bloc1_Level9":
                    Bloc1_Level9.Load();
                    break;
                case "Bloc1_Level10":
                    Bloc1_Level10.Load();
                    break;
                case "Bloc1_Level11":
                    Bloc1_Level11.Load();
                    break;

                default:
                    Debug.Log("No scene name");
                    break;
            }
        }
    }
}
