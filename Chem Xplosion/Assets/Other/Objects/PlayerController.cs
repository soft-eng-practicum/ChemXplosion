using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public bool isLooking = false;
	public Transform camDir;
	public float accel;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isLooking == true) {

		} else {
			float v = Input.GetAxisRaw ("Vertical");
			float h = Input.GetAxisRaw ("Horizontal");
			Vector3 force = new Vector3 (h, 0, v);

			force = camDir.TransformDirection (force);
			rb.AddForce (force.normalized * accel);

			rb.velocity = Vector3.ClampMagnitude (rb.velocity, speed);
			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);


		}
	}

	public bool setIsLooking (bool boolean) {
		return isLooking = boolean;
	}
}
