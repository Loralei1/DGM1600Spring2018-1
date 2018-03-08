using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCookies : MonoBehaviour {

public bool Magic = true;
public bool Saw = false;
/*These are declarations to be called later. They declare 
the data types, bools or booleans. Bools work in binaries. 
They are either true or false.  */
	// Use this for initialization
	void OnMouseDown () {
		if(Magic != true)
			print("You have used magic to make the tree grow faster!");
		
	}
	/* This if statement calls to the "Magic" bool. The 
	function checks on the truth of the statement inside the 
	parantheses. If the statement inside the parantheses is true--in
	this case, if "Magic" does not equal true--then 
	the console inside the game will print "Alohamora" 
	when a game object containing this script is clicked. 
	The if statement below works the same way. I have several
	other examples in the other scripts attached to this game.*/
	void OnMouseDrag()	{
		if(Saw == true)
			print("You have cut the tree down.");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
