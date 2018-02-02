using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChristmasGhosts : MonoBehaviour {

	public string Name;
	public int Charity;
	public int Shillings; 
	public bool Remembering;

	//These above are the variables to be called later on in the script. The bool defaults to false unless stated otherwise.

	// Use this for initialization
	void OnMouseDown () {
			if (Name == "Christmas Past")
		{ print ("Let us see another Christmas!");
		} else {
		print("Bah! Humbug!");
		}

		/* The if-statement above is checking on the truth of whether or not the name of a game object is "Christmas Past." If the name of the game object clicked is "Christmas Past", the statement is deemed
		 true, and the code below will run. If not, it moves onto the else clause, and will print "Bah! Humbug!" instead.*/
		
		if (Charity < 100)
		{ print ("Oh no! Tiny Tim has died!");
			} else {
			print ("Tiny Tim, who did not die, wishes everyone a Merry Christmas.");
		}

		/* This if-statement is using the less-than operator. If a clicked game objects charity count is less than 100, the code below--printing "Oh no! Tiny Tim has died!"-- will run. If not, it will move on to the
		  else clause, and ensure that (in this case) poor Tiny Tim will not die.*/

		if (Shillings >= 50)
			{print ("Bwahaha! To the counting house!");
			} else {
			print ("Nooo! My gold! OOOHHH NNOOOOOOO!!!");
		}

		/* This if-statement is using the greater-than-or-equals to operator. It functions on the same principles as the previous if-statements with else clauses. It was here I finally realized that the 
		 opening curly bracket must come after the initial if (true) declaration, otherwise the code will not run. */

			if (Remembering)
		{ print ("Why, it's good old Fezziwig!");
			} else {
			print ("I always hated Christmas!");
		}

		if (Name == "Scrooge" && Charity == 100) {
			print ("It's Christmas Day! I haven't missed it!");
		} else { 
			print ("Game Over.");
		}

			/* THis last if-statement is checking on the truth of two different variables. It is checking to see if a clicked game object's name is Scrooge and if the game object's charity count is 100. If either
			 of the variables don't match, the statement is declared true, and it defaults to running the code beneath the else-clause, and will print "Game Over," to the console. */
			}
}
	

