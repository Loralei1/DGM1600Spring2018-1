﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

	void Awake(){
		Time.timeScale = 1f;
	}

	public void PlayGame () {
		SceneManager.LoadScene(1);
	}

	public void LevelExit(){
		if (Input.GetButton ("Cancel"))
		{
			Debug.Log ("Game has closed.");
			Application.Quit ();
		}
	}
}