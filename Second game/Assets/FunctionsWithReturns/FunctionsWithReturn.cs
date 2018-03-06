using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturn : MonoBehaviour {

	public int Health; 
	public int ArmorClass;
	

	public int AddHealth(int value)
	{
		print("Hello there.");
		return Health += value;
	}

	public int AddArmorClass(int value)
{
	return ArmorClass += value;
}

	private void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("Bob"));
		ArmorClass = AddArmorClass(5);
		Weapons.Add(NewWeapons("Railsplitter"));
	}

	public List<string> Players;

	public List<string> NewPlayers()
	{
		return new List<string>();
	}

	public string NewPlayer(string name)
	{
		return name; 
	}
	
	public string[] Weapons;

	public string[] NewWeapons()
	{
		return new string[5];
	}


	// Use this for initialization
	 
	}



	//So the return value of the function is equal to the function's name. So
	//MyInt ends up assigned the value of the result of the AddHealth function. The function
	//IS an integer, because Functions with Return are Data Types.


