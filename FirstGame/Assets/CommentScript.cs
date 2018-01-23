using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentScript : MonoBehaviour {
    public CommentScript()
    {
    }
//I'm not entirely sure I understand everything.
//But here's how I understand it so far.
/*Scripting uses boxes within boxes. MonoBehavior
is a large box with other boxes inside of it. In this 
instance, it contains the "Comment Script" box, and the "class"
box. The "class" here is public, meaning that it is a type that 
is available to view. 

The class contains funtions. In this case it contains a void function. 
"Start" tells the function when to run (as soon as the game begins) and 
needs the "()" symbol to work. "Print" is a call containing data 
telling the function what to do (in this case, displaying the
words "I'm starting to get this," on the console screen). "Do" would be another call within the function,
though I'll admit I'm not entirely sure what "do" would "do."

Every line needs to close with a semi-colon, and each "box" of code needs 
to be contained within a set of "{}".
 */
    // Use this for initialization
    void Start () {
		print("I'm starting to get this.");
		print("Maybe.");
		print("It's kind of like a computer pidgen");
		
		
	}
 
	
	// Update is called once per frame
	void Update () {
		
	}
}
