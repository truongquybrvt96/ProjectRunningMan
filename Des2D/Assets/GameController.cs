using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour {
	public static GameController game;
	public GameObject startText;
	// Use this for initialization
	void Awake()
	{
		if (game==null)
			game = this;
		else if(game!=this) {
			Destroy (gameObject);
		}
	}

	public void ClearStartText()
	{
		startText.SetActive (false);
	}
	// Update is called once per frame
	void Update () {

	}

}
