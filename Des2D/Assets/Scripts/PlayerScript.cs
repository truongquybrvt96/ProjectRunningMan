using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 10f;
	private float horizon = 0f;
	Rigidbody2D myRig;
	// Use this for initialization
	void Start () {
		myRig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		horizon = Input.GetAxisRaw ("Horizontal");
		Vector3 pos = transform.position;
		pos.x += horizon * speed * Time.deltaTime;
		transform.position = pos;
		//myRig.velocity = new Vector2 (speed, myRig.velocity.y);
	}
}
