using System.Collections;
using System.Collections.Generic;
using RPG.Saving;
using UnityEngine;
using UnityEngine.Playables;


namespace RPG.Cinematics
{

    public class CinematicTrigger : MonoBehaviour, ISaveable
    {
        [SerializeField] bool isTriggered = false;

        public object CaptureState()
        {
            return isTriggered;
        }

        public void RestoreState(object state)
        {
            isTriggered = (bool)state;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (isTriggered) return;
            if (other.tag == "Player")
            {
                isTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }

        }
    }
}


