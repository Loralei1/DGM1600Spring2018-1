using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VoidFunctions : MonoBehaviour {

	public string userName; 
	public InputField myInputField;
	public int RunningSpeed; 
	// Use this for initialization
	void Start () {

		/*Void functions are functions which do work but return nothing. void Start () {}, for example, will begin the code which follows when the code starts to run, but it won't deliver anything back.
		The handy thing about void functions is that they can be called in other functions.*/



	}

	//The first two are from Anthony Romrell's DGM 1600 Fall 2017 repository on GitHub. 
	public void UpdateUserName ()
	{ 
		WelcomeUser (myInputField.text); 
	}

	void WelcomeUser (string _name)
	{
		UpdateUserName = _name; 
		print ("Welcome" + _name + ", get ready to play!"); 
	}

	public void UpdateRunningSpeed; 
	{
		UpdateRunningSpeed = a++; 
		print(RunningSpeed); 
	}


}
