using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenController : MonoBehaviour {

	public void PausePressed()
	{
		if (GlobalVariables.canMove) {
			GlobalVariables.canMove = false;
			this.gameObject.GetComponent<Canvas> ().enabled = true;
		}
		Debug.Log ("Paused");
	}


	public void PauseUnPressed()
	{
		this.gameObject.GetComponent<Canvas> ().enabled = false;
		GlobalVariables.canMove = true;
	}
}
