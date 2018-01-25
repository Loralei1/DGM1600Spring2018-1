using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal2 : MonoBehaviour {

	public string Name;

	public int FoodCount;

	

	void OnMouseDown()
	{
		print("I have a" + Name);
		print("It has " + FoodCount + " cookies.");	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
