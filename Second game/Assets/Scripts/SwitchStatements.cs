using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

	//Switch statements can be used in place of if statements.
	/* Structure is: 
	
		Switch () {}
		
		It is a built in function with built in operations. 
		Key word "case." Meant to designate what we're searching for.
		Switch (string) {
			case "Password": 
				// Do work
				break;
			
		Can be used for any kind of data. Numbers
		aren't typically switched.*/

				// Use this for initialization

	public string UserName;


	void Start () {
		
		switch (UserName)
		{
			
			case "Password":
				print("Password is correct.");
				break;

			case "Level Up":
			print("You win! Next level.");
				break; 

			case "BlackPanther":
				print("Made over 200 million this weekend!");
				break;

			default:
				print("No soup for you."); 
				break;
		}

	}
	

}
