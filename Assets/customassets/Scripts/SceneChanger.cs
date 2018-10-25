using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
		GlobalVariables.score = 0;
		GlobalVariables.speed = 0.09f;
		GlobalVariables.canMove = false;
	}

}
