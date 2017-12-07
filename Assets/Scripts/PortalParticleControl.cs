using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalParticleControl : MonoBehaviour {
	public bool isOn;
	public GameObject portalParticle;
	// Use this for initialization
	void Start()
	{
		UpdateParticles ();
	}

	public void UpdateParticles()
	{
		portalParticle.SetActive (isOn);
	}
}
