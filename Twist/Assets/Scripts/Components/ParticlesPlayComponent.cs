using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class ParticlesPlayComponent : MonoBehaviour
    {
        public ParticleSystem particleDeath;

        public void PlayParticle()
        {
            particleDeath.Play();
        }
    }
}
