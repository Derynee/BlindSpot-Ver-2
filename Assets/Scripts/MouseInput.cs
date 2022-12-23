using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"Acabas de hacer click sobre el objeto.{this.gameObject.name}");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log($"El mouse se encuentra encima de este objeto.{this.gameObject.name}");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log($"El mouse ya no esta encima de este objeto.{this.gameObject.name}");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log($"El mouse ya no esta dando click.{this.gameObject.name}");
    }
}
