using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

    public RectTransform selectedItem, selectedSlot, originalSlot;
	// Use this for initialization
	void Start () {
       // selectedItem = GetComponentInChildren<Item>().rectT;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            selectedItem.position = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            selectedItem.localPosition = Vector3.zero;
        }

	}
}
