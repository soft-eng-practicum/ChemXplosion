using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RemoveFromInventory : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler

{
    public static GameObject itemToRemove;
    public GameObject tooltip;
    Inventory inventory;



    public void Start()

    {

        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();



    }

    public void Update()
    {
        if(tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)

    {

        itemToRemove = gameObject;
        string item = itemToRemove.name.Remove(itemToRemove.name.Length - 1);
        print(itemToRemove + " will be removed");
        tooltip.transform.GetChild(0).GetComponent<Text>().text = item;
        tooltip.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        itemToRemove = null;
        tooltip.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)

    {
        if(itemToRemove != null)
        {
            print(itemToRemove.name);
            inventory.RemoveItem(itemToRemove);
            print("removed" + gameObject.name);
            tooltip.SetActive(false);
        }
        
    }
}