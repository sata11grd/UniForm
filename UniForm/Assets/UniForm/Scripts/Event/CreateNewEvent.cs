using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniForm.Event
{
    public class CreateNewEvent : EventBase
    {
        [SerializeField] TMPro.TMP_InputField inputField;

        protected override void Invoke()
        {
            inputField.text = "";
        }
    }
}