using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VoidFunctions : MonoBehaviour {

	public string userName; 
	public InputField myInputField;
	public int RunningSpeed; 
	public string CharacterName; 
	public string Weapons; 


	// Use this for initialization
	void Start () {

		/*Void functions are functions which do work but return nothing. void Start () {}, for example, will begin the code which follows when the code starts to run, but it won't deliver anything back.
		The handy thing about void functions is that they can be called in other functions.*/
		OnMouseDown (); 



	}

	//The first two are from Anthony Romrell's DGM 1600 Fall 2017 repository on GitHub. 
	/*public void UpdateUserName ()
	{ 
		WelcomeUser (myInputField.text); 
	}
*/
	/*void WelcomeUser (string _name)
	{
		UpdateUserName = _name; 
		print ("Welcome" + _name + ", get ready to play!"); 
	}*/

	 public void OnMouseDrag() 
	{
		RunningSpeed += 4; 
		print(RunningSpeed); 
	}
 
	public void OnMouseDown()
	{
		print (CharacterName); 
	}

	public void Update()
	{
		if (Input.GetKey("escape"))
			print ("Escape");
	}

	public void OnTriggerCollider(Collider other)
	{
		print ("Ow.");
	}

	public void OnTriggerExit()
	{
		print ("Whoops!");
	}

	public void OnTriggerStay(Collider other)
	{
		print ("Out of the way!");
	}

	public void fixedUpdate()
	{
		if (Input.GetKey("up"))
			transform.Rotate (new Vector3 (15, 30, 35) * Time.deltaTime);
	}
	//I'm having some trouble getting this last one to do anything. There aren't any error messages, but it doesn't do anything, either.

}
