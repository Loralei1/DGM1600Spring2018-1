using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour {

public int Goose;
public string Oven;

public float Temperature;

public bool Pepper;

public int Minutes; 
	// Use this for initialization
void OnMouseDown()
	{
		{
		if(Goose == 1 && Oven == "Hot")
		{ print ("Your goose is cooked.");
		}
	/*The above if-statement uses an and operator, 
	represented by the '&&' symbols. The statement 
	inside the first set of parantheses will only be
	considered true if both the Goose and the Oven are false. */

		if(Goose < 1 || Oven == "Cold")
		{ print ("You can't cook.");
		} 
	/*This if-statement is using or operator.
	The statement inside the parentheses will only be considered
	true if either the Goose is true or the Oven is true, or both.
	 */

		if(Goose > 1 ^ Oven == "Hot") 
		{print ("Out of luck, duck.");}
	/*And this if statement is using the xor or exclusive
	or operator. The statement inside the parantheses will 
	be considered true if either the Goose is true of the 
	oven is true, but never both.  */
	} 
		if (Temperature >= 425.5 && Oven == "Hot")
		{ print("The oven is ready.");}
		else { 
			print ("Not yet.");
		}
	
		if (Pepper = false ^ Goose == 1)
		{ print ("And now you take some seasoning....");}

		if (Pepper = true && Temperature >= 425.5)
		{ print ("Hurry up! You're falling behind!");}

		if (Goose < 1 || Temperature < 425.5)
		{ print ("There's nothing or no way to cook.");}

		if (Goose == 1 && Temperature > 425.5 && Minutes > 120)
		{ print ("You're going to burn the goose!");}

		if (Goose == 1 && Minutes == 105)
		{ print ("It's probably time to take it out.");}

		if (Oven == "Hot" ^ Temperature >= 425.5 ^ Pepper == true)
		{ print ("Something is probably not ready.");}

		/*There are probably shorter ways to do all of this, 
		but I'm trying to write in multiple examples of the 
		different operators. */
	/* There are three types of logical operators: the logical and;
	the logical xor, and the logical or.  */
	}
}
