using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShoot : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ShootFn();
		}
	}

	void ShootFn()
	{
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;

		if (Physics.Raycast (myRay, out hit)) 
		{
			Vector3 aim = hit.point;
			Vector3 dir = new Vector3 (aim.x - transform.position.x, 0, aim.y - transform.position.z);
			Instantiate (bullet, transform.position, Quaternion.identity);
		}
	}
		
}
