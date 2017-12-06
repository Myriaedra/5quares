using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	Quaternion myTargetrotation;
	public float rotationSpeed;

		void Start () 
		{

		}

		// Update is called once per frame
		void FixedUpdate () 
		{
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+rotationSpeed, transform.rotation.eulerAngles.z);
		}
}
