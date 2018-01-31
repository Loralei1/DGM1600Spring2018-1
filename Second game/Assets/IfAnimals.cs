using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfAnimals : MonoBehaviour {

	public string Name;

	public int AppleCount;

	// Use this for initialization
	void OnMouseDown()
	{
/*An if statement checks for the truth of the statement 
inside the parantheses. In this case, it is checking 
on the truth of whether or not the statements on 
each side of the equation are the same. Since 4+5 will
always be 9, this will always be true, and this function
will always carry out the work below--in this case, printing
"Good Morning" to the console when an object to which 
this script is attached is clicked.   */
	if (4 + 5 == 9); {
		print ("Good Morning.");
	}
	if (Name == "Apple Tree");
		print ("This is an " + Name + ".");
		print ("It has " + AppleCount + " apples.");

	/* This if statement utilizes variables. If the 
	name of a game object is "Apple Tree", it will 
	decide the statement inside the parantheses is true, 
	and do the work as described below. */
	if (AppleCount == 50);
		print("This year will be a good harvest.");

	if (AppleCount != 50);
		print("Oh no! This is not an apple tree. Alas! We don't know how to harvest almonds, and we will starve.");

	if (Name != "Apple Tree");
		print("This is an almond tree.");
	} 

	/* This if statement, on the other hand, will only 
	work if the game object clicked is not named "Apple Tree."
	If it is not, then it will decide the statement 
	inside the parantheses is true, and print "This is an 
	almond tree." If the game object clicked is named 
	"Apple Tree," however, the statement inside the parantheses
	will be false, and nothing will happen. */
		
	}

	
	// Update is called once per frame


