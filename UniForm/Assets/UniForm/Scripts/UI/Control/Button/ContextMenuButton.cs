using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UniForm.UI.Control.Button
{
    public class ContextMenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        [SerializeField] GameObject hoverOverlay;
        [SerializeField] UnityEvent onClick = new UnityEvent();

        void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
        {
            onClick.Invoke();
            hoverOverlay.SetActive(false);
            transform.parent.gameObject.SetActive(false);
        }

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
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
        }
    }
}