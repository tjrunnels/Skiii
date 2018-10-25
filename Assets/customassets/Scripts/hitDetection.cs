using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitDetection : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		GlobalVariables.canMove = false;
		GlobalVariables.deathCanMove = true;
	}

}