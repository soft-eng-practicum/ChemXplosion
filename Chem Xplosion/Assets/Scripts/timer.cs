using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text myTimer;

	public static int itemCounter;

	private float time;

	bool activeTimer;

	public static int toggleTimer = 0;

	void Start()
	{
		activeTimer = true;
	}

	void Update() {

		itemCounter = Onhit.counter;

		if (activeTimer == true) {
			time += Time.deltaTime;
		}

		float minutes =  Mathf.FloorToInt(time / 60f); 

		float seconds = time % 60f;

		float fraction = (time * 100f) % 100f;

		myTimer.text = string.Format ("{0:00} : {1:00} : {2:00} ", minutes, seconds, fraction);

		if (itemCounter == 2) {
			stopTimer ();
		}

		//*************** Timer Tester **********************

//		if (Input.GetButtonDown ("L")) {
//			toggleTimer++;
//		}
//
//		if (toggleTimer % 2 == 0) {
//			activeTimer = true;
//		} 
//		else {
//			activeTimer = false;
//		}

		//*************** Timer Tester ***********************

	}

	void stopTimer(){
		activeTimer = false;
	}
}

