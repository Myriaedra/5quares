using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : MonoBehaviour {
	public GameObject bullet;
	public GameObject aimObject;
	public float shotForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shoot ();
		}
	}

	public void Shoot()
	{
		GameObject tempBullet = Instantiate (bullet, aimObject.transform.position, aimObject.transform.rotation);
		Rigidbody rB = tempBullet.GetComponent<Rigidbody> ();
		rB.velocity = tempBullet.transform.forward * shotForce;

		Destroy (tempBullet, 5);
	}
		
}
