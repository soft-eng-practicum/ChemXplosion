using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.EventSystems;



public class RemoveFromInventory : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler

{
    public static GameObject itemToRemove;
    Inventory inventory;



    public void Start()

    {
        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();
    }

    public void OnPointerEnter(PointerEventData eventData)

    {

        itemToRemove = gameObject;
        print(itemToRemove + " will be removed");
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        itemToRemove = null;
    }

    public void OnPointerClick(PointerEventData eventData)

    {
        if(itemToRemove != null)
        {
            print(itemToRemove.name);
            inventory.RemoveItem(itemToRemove);
            print("removed" + gameObject.name);
        }
        
    }
}