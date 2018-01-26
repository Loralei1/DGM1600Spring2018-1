using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {

    public string (Name);
	public int (CookieCount);
	public float (Hours);
	public string (Color);
    /* The four lines above are declarations. They declare the call names of the 
    variables used later on in the script and what kind of data they contain. 
    A string is a string of characters, an integer is a whole number, and a float is a number with at
    least one decimal place.  */
    void OnMouseDown()
    
	{
		print("He has a " + Name ".");
		print("It has " + CookieCount + " cookies.")
		print("It has had them for " + Hours + " hours.")
	}

    /*The variables are called here in the print functions. This code can be attached to multiple
    game objects which will then gain the attributes "Name," "CookieCount," and "Hours." A different 
    string, integer, or float can be entered for each game object. One, for example, can be 
    a chameleon with 3 cookies, having had them for 6.5 hours, while another can be a 
    parakeet with 7 cookies, having had them for 3.25 hours. */

	void OnMouseOver()

	{
		print("This is a " + Color + Name ".")
    
    /*This function calls to two different variables, "Color" and "Name." 
    This should, theoretically, print, "This is a" plus the variable entered 
    for "Color" and the variable entered for "Name" when the mouse cursor 
    hovers over a game object. For example, if we hover over a game object
    with "lizard" in the name category and "green" in the Color category, 
    the console should display the words, "This is a green lizard," when the
    a mouse curor hovers over that game object. 
    
    I say theoretically, because I haven't yet been able to get this code to work.*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	}
	
	