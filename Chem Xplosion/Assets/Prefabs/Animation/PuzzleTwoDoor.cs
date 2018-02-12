using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTwoDoor : MonoBehaviour {
	private Animator p2Animate;
	// Use this for initialization
	void Start () {
		p2Animate = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("q")) {
		p2Animate.SetBool ("puzzleTwo", true);	
		}
	}
}
