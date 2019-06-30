using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniForm.Event
{
    public abstract class EventBase : MonoBehaviour
    {
        protected abstract void Invoke();

        private void OnEnable()
        {
            Invoke();
            gameObject.SetActive(false);
        }
    }
}