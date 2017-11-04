using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

	private Animator dAnimate;
	public static int dCounter = 0;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			dAnimate.SetBool ("open", true);
			//dCounter++;
		}
		}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			closeDoor();
			//dCounter--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	void closeDoor(){
		dAnimate.SetBool ("open", false);
	}
}
