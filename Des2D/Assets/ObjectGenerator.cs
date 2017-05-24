using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour {

	public GameObject gameOb;
	public Transform spawnTarget;
	void Start () {
		StartCoroutine ( Spawn() );
	}
	
	IEnumerator Spawn()
	{
		float randomSpawningTime = Random.Range (1f, 3f);
		yield return new WaitForSeconds (randomSpawningTime);
		Vector2 pos = new Vector2 (spawnTarget.position.x, 1);
		Instantiate (gameOb, pos, Quaternion.identity);
		StartCoroutine ( Spawn() );
	}
}
