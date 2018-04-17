using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour {

	private Animator dAnimate;

    [HideInInspector]
    public bool withinArea = false;
    public bool isOpen = false;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
            withinArea = true;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
            withinArea = false;
		}
	}

    public void ActiveAnimation() {
        if (withinArea == true) {
            dAnimate.SetBool("open", true);
            isOpen = true;
        }
    }
}
