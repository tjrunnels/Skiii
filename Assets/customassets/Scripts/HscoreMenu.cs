using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HscoreMenu : MonoBehaviour {

	public Text hscre;

	void Update()
	{
		hscre.text = "High Score: " + GlobalVariables.highscore;
	}
}
