using System;
using Phantom_Dragon_Studio.Environment;
using UnityEngine;

namespace PhantomDragonStudio.Environment
{
    public class BasePlatform : MonoBehaviour, IActivatable
    {
        protected float timeToBeActive = -1;
        protected float currentLifeTime;
        protected bool isActive;
        
        public bool IsActive { get => isActive; set => isActive = value; }
        /// <summary>
        /// Defaults to -1 for permanent activation.
        /// </summary>
        public float TimeToBeActive { get => timeToBeActive; set => timeToBeActive = value; }

        public void Activate()
        {
            currentLifeTime = 0;
            isActive = true;
            this.gameObject.SetActive(true);
        }

        public void Deactivate()
        {
            isActive = false;
            this.gameObject.SetActive(false);
        }

        private void Update()
        {
            //TODO Add visual and audio queues to indicate the platform's lifecycle is coming to an end.
            if (!(timeToBeActive > -1)) return;
            currentLifeTime += Time.deltaTime;
            if (currentLifeTime > timeToBeActive)
            {
                Deactivate();
            }
        }
    }
}