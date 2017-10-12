using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text myTimer;

	public static int itemCounter;

	private float time;

	bool activeTimer;

	void Start()
	{
		activeTimer = true;
	}

	void Update() {

		itemCounter = Onhit.counter;

		if (activeTimer == true) {
			time += Time.deltaTime;
		}

		float minutes = time / 60f; 

		float seconds = time % 60f;

		myTimer.text = string.Format ("{0:00} : {1:00}", minutes, seconds);

		if (itemCounter == 3) {
			stopTimer();
		}

	}

	void stopTimer(){
		activeTimer = false;
	}
}

