using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GameObject[] portals = new GameObject[5];
	public string[] keys = new string[]{"space", "s", "e","r","t"};
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 5; i++)
		{
			if (Input.GetKeyDown(keys[i]))
			{
				transform.position = portals[i].transform.position;
			}
		}
	}
}
