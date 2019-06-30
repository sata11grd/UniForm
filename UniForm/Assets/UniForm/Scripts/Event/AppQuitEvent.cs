using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniForm.Event
{
    public class AppQuitEvent : EventBase
    {
        protected override void Invoke()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }
    }
}