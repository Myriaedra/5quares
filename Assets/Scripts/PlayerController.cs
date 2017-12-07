using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject[] portals = new GameObject[5];
	public string[] keys = new string[]{"space", "s", "e","r","t"};
	public GameObject currentPortal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 5; i++)
		{
			if (Input.GetKeyDown(keys[i]))
			{
				Vector3 portalPosition = portals [i].transform.position;
				currentPortal.GetComponent<PortalParticleControl> ().isOn = false;
				currentPortal.GetComponent<PortalParticleControl> ().UpdateParticles ();

				transform.position = new Vector3 (portalPosition.x, transform.position.y, portalPosition.z);
				currentPortal = portals [i];
				portals [i].GetComponent<PortalParticleControl> ().isOn = true;
				portals [i].GetComponent<PortalParticleControl> ().UpdateParticles ();
			}
		}
	}
}
