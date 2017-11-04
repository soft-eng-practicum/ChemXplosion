using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

	private Animator dAnimate;
	public bool close = true;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			dAnimate.SetBool ("open", true);
			close = false;
		}
		}
	
	// Update is called once per frame
	void Update () {
		if (close == false) {
			Invoke ("closeDoor", 3);
		}
	}

	void closeDoor(){
		dAnimate.SetBool ("open", false);
		close = true;
	}
}
