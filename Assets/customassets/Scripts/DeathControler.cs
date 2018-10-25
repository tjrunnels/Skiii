using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathControler : MonoBehaviour {

	public Text Hscore;

	public void ResetButtonPressed(string scene)
	{
		SceneManager.LoadScene (scene);
		GlobalVariables.speed = 0.09f;
	}

	// Update is called once per frame
	void Update () {
		Hscore.text = "High Score: " + GlobalVariables.highscore;
		if (GlobalVariables.score > GlobalVariables.highscore) {
			//Add flashing High score
			GlobalVariables.highscore = GlobalVariables.score;
			variables.Save ();
		}


	}
}
