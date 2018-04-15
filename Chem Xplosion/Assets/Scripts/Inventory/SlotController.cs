using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour {

   // public RectTransform rectT;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouse() {
       GetComponentInParent<InventoryController>().selectedSlot.GetComponent<RectTransform>().position = this.GetComponent<RectTransform>().position;
    }
}
