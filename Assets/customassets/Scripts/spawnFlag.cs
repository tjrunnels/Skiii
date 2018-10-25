using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFlag : MonoBehaviour {

	public Transform MidFlag;
	public Transform LeftFlag;
	public Transform RightFlag;
	public Transform scoreFloor;
	float randy=0;
	public int distance;
	public int bottom;
	Vector3 temp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//At Start
		if (GlobalVariables.flagCount == 0) {
			for (int i = 0; i < 10; i++) {
				GlobalVariables.flagCount++;
				randy = Random.Range (0, 3);
				temp = new Vector3 (0, -10 - (i * distance), 0);
				if (randy == 0)
					Instantiate (LeftFlag,	temp, Quaternion.identity);
				else if (randy == 1)
					Instantiate (MidFlag,	temp, Quaternion.identity);
				else
					Instantiate (RightFlag,	temp, Quaternion.identity);
				//Score Floor
				Instantiate (scoreFloor, temp, Quaternion.identity);
			}
		}


//		Debug.Log (GlobalVariables.flagCount);
		if ((GlobalVariables.flagCount < 10)) {
			Debug.Log ("Spawn");
			GlobalVariables.flagCount++;
			randy = Random.Range(0,3);
			temp = new Vector3 (0, bottom, 0);
			if(randy == 0)
				Instantiate (LeftFlag,	temp, Quaternion.identity);
			else if (randy == 1)
				Instantiate (MidFlag,	temp, Quaternion.identity);
			else
				Instantiate (RightFlag,	temp, Quaternion.identity);
			//Score Floor
				Instantiate (scoreFloor,temp, Quaternion.identity);

		}
	}
}
