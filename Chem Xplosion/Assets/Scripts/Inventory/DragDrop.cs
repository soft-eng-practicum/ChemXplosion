using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;
    //public RectTransform dropPanel;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // Vector3[] worldCorners = new Vector3[4];
        //dropPanel.GetWorldCorners(worldCorners);

       // if (Input.mousePosition.x >= worldCorners[0].x && Input.mousePosition.x < worldCorners[2].x && Input.mousePosition.y >= worldCorners[0].y && Input.mousePosition.y < worldCorners[2].y) {
            if (transform.parent == startParent)
            {
                transform.position = startPosition;
            itemBeingDragged = null;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
       // }

        
    }
}
