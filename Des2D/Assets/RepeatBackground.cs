using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {
	private float dBI = 26.78f;//distance between 2 images
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x + dBI*2 < player.transform.position.x) {
			RepBack ();
		}
	}
	private void RepBack()
	{
		Vector2 offset = new Vector2 (dBI * 3, 0);
		this.transform.position = (Vector2)transform.position + offset;
	}
}
