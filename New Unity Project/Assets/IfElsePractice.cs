using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElsePractice : MonoBehaviour {

	public string name; 
	public string weapon;
	public int HP;


	void OnMouseDown () {
		if (name == "Taako")
		{ 
			print ("Taako's good out here");
		} 
		else 
		{
			print("Magnus rushes in!");
		}


		if (weapon != "Railsplitter") 
		{
			print ("That's not my ax!");
		} 
		else 
		{
			print ("Mwahaha!");
		}

		if (HP < 10 && name == "Taako")
		{
			print ("Is it, Griffin? Is it? Is it REAL LOW?!");
		}
		else
		{
			print ("Yeah, I'm good.");
		}

	}
			

}
