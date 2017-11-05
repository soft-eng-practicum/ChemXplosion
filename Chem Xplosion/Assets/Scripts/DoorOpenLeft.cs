using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenLeft : MonoBehaviour {
	public static bool triggered;
	private Animator dAnimate;
	// Use this for initialization
	void Start () {
		
		dAnimate = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		triggered = DoorOpener.trigger;
		if (triggered == true) {
			dAnimate.SetBool ("open", true);
		} else {
			dAnimate.SetBool ("open", false);
		}
	}
}
