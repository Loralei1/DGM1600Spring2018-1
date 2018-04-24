using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {

	public List<GameObject> Enemies; 
	public int NumberOfEnemies; 
	public Text EnemyText;

	// Use this for initialization
	void Start () 

	{
		NumberOfEnemies = 0;
		EnemyText.text = "Enemies";
	}
	
	// Update is called once per frame
	void Update () 
	{ while (NumberOfEnemies <= 4) 
		{
		
			foreach (GameObject Enemies in Enemies)
				NumberOfEnemies += 1;
				EnemyText.text = NumberOfEnemies + " Enemies";
		}
	

	}
}
