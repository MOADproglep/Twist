using UnityEngine;
using UnityEngine.Events;
using IJunior.TypedScenes;

namespace Assets.Scripts.Components
{
    public class LoadSceneComponent : MonoBehaviour
    {
        //public UnityEvent OnFinishLevel;

        public void OnTrigerFinish()
        {
            //OnFinishLevel?.Invoke();

            Bloc1_Level2.Load();
        }

        
       
    }
}
