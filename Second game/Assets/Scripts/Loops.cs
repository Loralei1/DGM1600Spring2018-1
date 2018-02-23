using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	/*


	The are several different kinds of loops. 

	First, there is the while loop, which will repeat so long as its conditional is true. For example:

	public int NumberOfEnemies;

	while(NumberOfEnemies <= 0) {
	print("There are no enemies); 
	}

	will print "There are no enemies," to the console as long as the variable number of enemies is less than or equal to zero. 

	Then there is the do while loop. The do while loop is almost identical to the while loop, except that the loop will run at least one before 
	exiting even if the conditional is false. For example: 


		public in NumberOfEnemies; 

	do {
		print ("There are no enemies.");
		}

	while (NumberOfEnemies <= 0);

	"There are no enemies," will print to the console even if the number of enemies is more than zero, because the loop runs at least one time. 

	The for loop has three parts, the declared variable, the conditional, and the section meant ot change the variable. 

	public int NumberOfEnemies;  

			for(int i = 0; i < NumberOfEnemies; i++)
			{
			print (i);
			}
	"int i = 0" declares a variable to be used in this function. This part is optional. "i < NumberOfEnemies" is the conditional; so long as this part is true, the third 
	section, "i++", will add 1 to the variable every time the for loop runs. 


	Lastly, the for each loop, useful in arrays, runs through a collection item by item until it reaches the end of that collection. For example: 


	foreach("Sword" in "Weapons") 
	{
	print(Name); 
	}
	The foreach loop loops through a collection item by item until it 
		reaches the end of a collection.*/ 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
