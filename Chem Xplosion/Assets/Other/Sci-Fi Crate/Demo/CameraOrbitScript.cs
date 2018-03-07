/**
 * Copyright (c) 2015 Salin Nikolai
 * Visit https://www.assetstore.unity3d.com/en/#!/publisher/9731
 * Twitter https://twitter.com/LefDev
 **/

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraOrbitScript : MonoBehaviour 
{
	// rotation
	[Range(-359, 359)]
	public float rotationX = -45f;
	[Range(10, 70)]
	public float rotationY = 30f;

	// distance to object
	public float distance = 3f;
	
	// min distance to object
	public float minDistance = 2f;
	// max distance to object
	public float maxDistance = 6f;
	
	// zoom speed
	public float zoomSpeed = 10f;
	
	// camera movement speed
	public float moveSpeed = 15f;
	// speed damping
	public float speedDamping = 2.5f;
	
	// rotation velocity
	private float _velocityX = 0f;
	private float _velocityY = 0f;
	// zoom velocity
	private float _zoomVel = 0f;
	
	void Start () 
	{
		UpdateCamera();
	}
	
	void LateUpdate () 
	{
		Zoom();
		Move();
		UpdateCamera();
	}
	
	void Zoom()
	{
		_zoomVel -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
		// apply velocity
		distance += _zoomVel;
		// clamp
		distance = Mathf.Clamp(distance, minDistance, maxDistance);
		// damp velocity
		_zoomVel = Mathf.Lerp(_zoomVel, 0, Time.deltaTime * speedDamping);
	}
	
	void Move()
	{
		if (Input.GetMouseButton(0))
		{
			_velocityX += Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
			_velocityY += Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
			
		}
		// apply velocity
		rotationX += _velocityX;
		rotationY -= _velocityY;
		// clamp
		rotationX = ClampAngle(rotationX);
		rotationY = Mathf.Clamp(rotationY, 10f, 70f);
		// damp velocity
		_velocityX = Mathf.Lerp(_velocityX, 0, Time.deltaTime * speedDamping);
		_velocityY = Mathf.Lerp(_velocityY, 0, Time.deltaTime * speedDamping);
	}
	
	float ClampAngle(float angle)
	{
		if (angle <= -360f )
			return angle + 360f;
		else if (angle >= 360f)
			return angle - 360f;
		else
			return angle;
	}
	
	void UpdateCamera()
	{
		Quaternion rot = Quaternion.Euler(rotationY, rotationX, 0f);
		
		Vector3 pos = rot * new Vector3(0, 0, -distance);
		
		// update transform
		transform.rotation = rot;
		transform.position = pos;
	}
}
