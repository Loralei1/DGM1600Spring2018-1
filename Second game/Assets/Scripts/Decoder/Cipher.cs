using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public abstract class Cipher : ScriptableObject {

	/* A function with return is one that, unlike a void function, gives things back when the code is run. This particular return function, along with the return functions in the scriptable objects that will
	 * be children to this function is supposed to return a string array entered into the text input
	 * box, but shifted a number of letters to the right or left. I haven't been able to correct all the errors in this part of the script yet, unfortunately.*/ 

	protected string Input;

	public string Cshift(Input t)
	{ 
			return FinishCipher(); 
	


/*In the code above, I'm attempting to convert the characters in the strings entered into Input to a character array so they can be shifted and returned into DecipherText. I was trying
to use the Calculation script as a base, since there are several different ciphers I want to use that do more or less the same thing and would make decent scriptable objects, but I'll probably have to do it differently.*/ 

		}

	public abstract string FinishCipher(); 

//Access modifiers determine which scripts can see which classes. 'Public' means that all scripts will be able to see a class; protected means that only the children of the class can see that class or variable. 
//Both modifiers are used in this script. A third modifier, Private, means it is only viewable by the script it is in. 
}




