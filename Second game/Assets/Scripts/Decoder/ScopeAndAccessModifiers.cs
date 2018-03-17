using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour {


	public string PlayerName; 

	public int Health; 

	public bool Key;

	//The three variable classes above have public access modifiers. This means that these variables can be seen by any class. 

	private float Speed; 

	private string[] MagicalItems; 

	private List<string> Weapons; 

	//The three variables above this have private access modifiers, which means they can only be seen by the script in which they appear. 

	protected char A; 

	protected int Score; 

	protected bool Door = true; 

	protected float Height; 

	//The four variables above have a protected access modifier. It's kind of an inbetween of private and public. Variables with protected access modifiers can be seen by other scripts or classes, 
	//but only if those scripts or classes are children of the main class. 


	// Use this for initialization
	void Start () {


	}


}
