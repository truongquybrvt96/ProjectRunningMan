using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Destroy") {
			Destroy (gameObject);
		}
	}

}
