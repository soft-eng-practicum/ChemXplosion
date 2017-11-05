using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour {
	public Light lt;
	public static int puzzlecount;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		puzzlecount = Onhit.counter;

		if (puzzlecount == 2) {
			lt.color = Color.green;
		}
	}
}
