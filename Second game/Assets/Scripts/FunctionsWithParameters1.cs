using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters1 : MonoBehaviour {
//Colliders hit and stop triggers pass through each other.
	
	public int Health = 20;

	public int ArmorClass = 11;

	private void OnTriggerEnter(Collider other)
	{
			print("Hit something.");
			print(other);

			AddHealth(25);

			AddNumbers(14, 2);

			PlayerData("Bob");

			PlayerWeapons("Scythe");

			SubNumbers(50, 40);

			AddArmorClass(15);

			PlayerTrinkets("tin soldier missing a head")
	}

	void AddHealth (int newHealth)
			{
				Health += newHealth;
			}

	void AddNumbers (int a, int b)
	{
			print(a += b);
	}

	void PlayerData(string name)
	{
		print("This player is " + name);
	}

	void PlayerWeapons(string name)
	{
		print("You have picked up a scythe.");
	}

	void SubNumbers (int c, int d)
	{
		print (c -= d);
	}

	void AddArmorClass(int NewArmor)
	{
		ArmorClass += NewArmor; 
	}

	void SubArmorClass(int NewArmor)
	{
		ArmorClass -= NewArmor; 
	}

	void PlayerTrinkets(string trinkets)
	{
		print("You have a " + trinkets + ".");
	}


}


