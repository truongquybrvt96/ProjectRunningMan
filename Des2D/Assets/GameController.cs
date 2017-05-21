using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour {
	public static GameController game;
	public GameObject startText,pauseText;
	public bool isStart=false;
	private bool isPause = false;
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
		if (Input.GetKeyDown (KeyCode.Space)) {
			isStart = true;
		}
		if (Input.GetKeyDown (KeyCode.Escape) && isStart) {
			isPause = !isPause;
		}	
		if (isPause) {
			pauseText.SetActive (true);
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
			pauseText.SetActive (false);
		}
	}

}
