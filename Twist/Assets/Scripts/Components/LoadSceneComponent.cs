using UnityEngine;
using UnityEngine.Events;
using IJunior.TypedScenes;
using System.Collections;

namespace Assets.Scripts.Components
{
    public class LoadSceneComponent : MonoBehaviour //ДАНЯ загрузку тута делать 
    {
        [Space][Header("Animation Transite Settings")]
        public Animator animationTransitScene;
        public float transitionTime;//Time delay for animation

        //public UnityEvent OnFinishLevel;

        public void OnTrigerFinish()
        {
            //OnFinishLevel?.Invoke();
            //Bloc1_Level2.Load();

            StartCoroutine(LoadSceneAnimationtransite());
        }

        
       IEnumerator LoadSceneAnimationtransite()//тут нужно будет скорее всего передать аргумент для конкретной сцены
        {
            animationTransitScene.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);


            Bloc1_Level2.Load();//вот это место нужно будет заменить 
        }
    }
}
