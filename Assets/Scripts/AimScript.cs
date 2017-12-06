using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript: MonoBehaviour {
	public GameObject aimTarget;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AimUpdate ();
	}

	void AimUpdate()
	{
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;

		if (Physics.Raycast (myRay, out hit)) 
		{
			Vector3 aim = hit.point;
			transform.LookAt(new Vector3 (aim.x, transform.position.y, aim.z));
			aimTarget.transform.position = new Vector3 (aim.x, aimTarget.transform.position.y, aim.z);
		}
	}
}
