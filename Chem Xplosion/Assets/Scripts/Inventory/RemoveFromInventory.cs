using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RemoveFromInventory : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    Inventory inventory;

    public void Start()
    {
        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("Hoovering" + gameObject.name);
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            print("tryinig");
            inventory.RemoveItem(gameObject);
            print("removed" + gameObject.name);
        }
}

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        inventory.RemoveItem(gameObject);
        print("removed" + gameObject.name);
    }
}
