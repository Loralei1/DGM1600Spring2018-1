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
	public int A = 10;
	public bool Key; 
	public string Code;
	public string CharacterName;
	public int Journals; 
	public int Countdown; 
	public string Monster; 

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

		switch (A)
		{
		case 10:
			print ("10");
			break;

		}

		switch (Key) {
		case (true):
			print ("You can open the portal.");
			break;
		}

		switch (Code) {
		case "Pqxv tbfoa!":
			print ("Stay weird!");
			break; 
		}

		switch (CharacterName) { 
		case "Dipper":
			print ("Vengeance is underrated! That felt awesome!");
			break; 

		case "Mabel":
			print ("Ah! The puppet handbooks didn't warn me about this!"); 
			break; 

		case "Stan":
			print ("It's a unicorn made OUT of corn--the CORNICORN!"); 
			break; 

		case "Ford":
			print ("SCIENCE!!!!"); 
			break; 

		case "Bill":
			print ("HERE'S SOME DEER TEETH! FOR YOU, KID!");
			break; 

		case "Soos":
			print ("I'm not a pig! I'm a man tripped in a pig's body!");
			break;

		case "Pacifica":
			print ("We're PERFECT.");
			break;

		case "Cosmic":
			print ("AXOLOTL");
			break; 

		}

		switch (Journals) {
		case (3):
			print ("After all these years, I finally have them all.");
			break;
		}

		switch (Countdown) {
		case (10):
			print ("It's the final countdown!");
			break; 
		}

		switch (Monster) {
		case "Summerween Trickster":
			print ("Trick or Treat!"); 
			print ("Ugh! This is loser candy!"); 
			break; 
		}



	}
	

}
