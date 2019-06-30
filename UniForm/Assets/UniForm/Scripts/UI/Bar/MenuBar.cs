using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniForm.UI.Bar
{
    public class MenuBar : MonoBehaviour
    {
        List<Control.Button.MenuButton> menuButtons = new List<Control.Button.MenuButton>();

        private void Awake()
        {
            foreach(Transform child in transform)
            {
                menuButtons.Add(child.GetComponent<Control.Button.MenuButton>());
            }
        }

        public void DeselectAll()
        {
            menuButtons.ForEach(item => item.Deselect());
        }
    }
}