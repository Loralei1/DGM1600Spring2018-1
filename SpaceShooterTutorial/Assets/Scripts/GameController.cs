using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject Hazard; 
	public Vector3 spawnValue; 
	public int HazardCount;
	public float SpawnWait;
	public float startWait;
	public float WaveWait;

	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}
	IEnumerator SpawnWaves ()
	{
		while (true) {
			yield return new WaitForSeconds (startWait);
			for (int i = 0; i < HazardCount; i++) {
				yield return new WaitForSeconds (SpawnWait);
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z); 
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Hazard, spawnPosition, spawnRotation);

			}

			yield return new WaitForSeconds (WaveWait);
		}

	}
}
