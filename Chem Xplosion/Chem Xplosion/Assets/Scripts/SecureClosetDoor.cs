using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecureClosetDoor : MonoBehaviour {

	private Animator sAnimator;
	// Use this for initialization
	void Start () {
		sAnimator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "Player")
			{
				sAnimator.SetBool ("sOpen", true);
			}
				
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.tag == "Player") 
		{
			sAnimator.SetBool ("sOpen", false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
