using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

//public string[] Players;
public int [] HighScores;
public PowerUp[] PowerUps;
public Player[] Players; 
	public int[] Health;
	public Weapon [] Weapons;
	public int[] GoldPieces;
	public float[] Speed;
	public int [] Diamonds;
	public Armor[] Armors;
	public int [] Trinkets; 

	/* The ten lines above are arrays. Arrays are declared by square brackets and hold a range of variables as large or as small 
	as necessary, so long as those variables are of the same type. The PowerUps, Players, Weapons, and Armors arrays call to scriptable objects.
	One of the benefits of using arrays is being able to edit variables without rewriting script; it can be done in Unity.*/

	// Use this for initialization
	void Start () {
	foreach (var player in Players)
	{
		print(player.PlayerName);
		print(player.Score);
		print(player.MPs);
	}

	foreach (var score in HighScores)
	{
		if(score >= 1000)
		{
			print(score);
		}
	}

		foreach (var health in Health) {
			if (health <= 0) {
				print ("Game Over.");
			}
		}

		foreach (var Weapon in Weapons) {
			print (Weapon.WeaponName);
		
		}

		foreach (var gold in GoldPieces) { 
			print (gold);
		}

		foreach (var speed in Speed) {
			if (speed >= 5) {
				print ("Run");
			}
		}

		foreach (var diamond in Diamonds) {
			print (diamond);
		}

		foreach (var Armor in Armors) {
			print (Armor.ArmorName);
		}

		foreach (var trinket in Trinkets) {
			print (trinket);
		}

		/* The lines of code above are all foreach loops. They allow for work to be done with as many variables are contained in an array, and will do work for each variable in that array (or each variable in that
		array which falls in the correct guidelines if an if-statement is included as part of the foreach loop). Foreach loops allow for huge amounts of work to be done without 
		having to write a line of code for each and every variable. */
	}

}
