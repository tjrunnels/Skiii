using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDectecion : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		GlobalVariables.score++;
	}

}