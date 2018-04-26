using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour {

	private Animator dAnimate;
	public static int counter = 0;
	bool test = false;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			test = true;
			counter++;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			test = false;
			counter--;
		}
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("e") && test == true){
			dAnimate.SetBool ("open", true);
            GetComponent<ItemTooltip>().tooltip.SetActive(false);
            Destroy(GetComponent<ItemTooltip>());
        }
	}
}
