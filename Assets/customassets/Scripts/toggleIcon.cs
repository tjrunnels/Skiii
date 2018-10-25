using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleIcon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	public void toggle()
	{
		if(!GlobalVariables.musicMute)
			this.gameObject.GetComponent<Image> ().sprite = (Sprite)Resources.Load ("Modern_GUI_Skin.sound_on2.png");
		else
			this.gameObject.GetComponent<Image> ().sprite = (Sprite)Resources.Load ("Modern_GUI_Skin.sound_off2.png");
		
	}
}
