using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



public static class GlobalVariables{
	public static bool musicPlaying = false;
	public static bool canMove = false; 
	public static bool deathCanMove = false;
	public static int flagCount = 0;
	public static int score = 0;
	public static float speed = 0.09f;
	public static int highscore;

	//options
	public static bool musicMute = false;
	public static bool SFXMute = false;
	public static int skiierColor = 0;
}


public class variables : MonoBehaviour {

	void Start()
	{
		Application.targetFrameRate = 60;
		DontDestroyOnLoad (this.gameObject);
		saveLoad ();
	}

	void saveLoad()   //IT'S NOT PUBLIC
	{
		if (File.Exists (Application.persistentDataPath + "/userInfo.dat")) {
			Debug.Log ("exists");
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream lfile = File.Open (Application.persistentDataPath + "/userInfo.dat", FileMode.Open);
			SaveData ldata = (SaveData)bf.Deserialize (lfile);
			lfile.Close ();

			GlobalVariables.musicMute = ldata.musicMute;
			GlobalVariables.SFXMute = ldata.sfxMute;
			GlobalVariables.highscore = ldata.highscore;
		} else {
			Debug.Log ("dnExist");
			File.Create (Application.persistentDataPath + "/userInfo.dat");

		}
	}

	public static void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream sfile = File.Open (Application.persistentDataPath + "/userInfo.dat", FileMode.Open);

		SaveData sdata = new SaveData ();
		sdata.musicMute = GlobalVariables.musicMute;
		sdata.sfxMute = GlobalVariables.SFXMute;
		sdata.highscore = GlobalVariables.highscore;

		bf.Serialize (sfile, sdata);
		sfile.Close ();
	}
}
	
[System.Serializable]
class SaveData
{
	public bool musicMute;
	public bool sfxMute;
	public int highscore;

}