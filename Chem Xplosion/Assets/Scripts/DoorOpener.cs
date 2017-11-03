using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

	private Animator dAnimate;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			dAnimate.SetBool ("open", true);
		}
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
