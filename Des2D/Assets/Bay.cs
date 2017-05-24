using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bay : MonoBehaviour {

	private Rigidbody2D r2;
	// Use this for initialization
	void Start () {
		r2 = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			r2.AddForce (new Vector2(0, 300));
		}
	}
}
