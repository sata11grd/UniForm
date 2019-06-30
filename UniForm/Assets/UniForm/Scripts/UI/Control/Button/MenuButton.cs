using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UniForm.UI.Control.Button
{
    public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] GameObject hoverOverlay;
        [SerializeField] GameObject pressOverlay;
        [SerializeField] UnityEvent onSelect = new UnityEvent();
        [SerializeField] UnityEvent onDeselect = new UnityEvent();
        [SerializeField] bool isSelected = false;

        void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
            hoverOverlay.SetActive(true);
        }

        void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
            hoverOverlay.SetActive(false);
        }

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            if (isSelected)
            {
                Deselect();
            }
            else
            {
                Select();
            }
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
        }

        public void Select()
        {
            transform.parent.GetComponent<Bar.MenuBar>().DeselectAll();
            onSelect.Invoke();
            isSelected = true;
            pressOverlay.SetActive(true);
        }

        public void Deselect()
        {
            onDeselect.Invoke();
            isSelected = false;
            pressOverlay.SetActive(false);
        }
    }
}