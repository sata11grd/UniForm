using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

namespace UniForm.Event
{
    public class LaunchStackEvent : EventBase
    {
        protected override void Invoke()
        {
            var process = new Process();
            process.StartInfo.FileName = "stack.jar";
            process.Start();
        }
    }
}