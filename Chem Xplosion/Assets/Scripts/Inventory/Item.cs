using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
   // public RectTransform rectT;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnMouse()
    {
        GetComponentInParent<InventoryController>().selectedItem.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
        print("Inside");
    }
}
