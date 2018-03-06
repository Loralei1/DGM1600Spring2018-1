using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters1 : MonoBehaviour {
//Colliders hit and stop triggers pass through each other.
	
	public int Health = 20;

	private void OnTriggerEnter(Collider other)
	{
			print("Hit something.");
			print(other);

			AddHealth(25);

			AddNumbers(14, 2);

			PlayerData("Bob");
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
}
