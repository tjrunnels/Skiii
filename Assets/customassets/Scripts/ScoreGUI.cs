using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreGUI : MonoBehaviour {

	public Text score;

	void Update () {
		
			score.text = "Score: " + GlobalVariables.score;	
	}
}