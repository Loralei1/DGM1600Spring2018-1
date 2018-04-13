using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public GameObject other;

	private void OnTriggerEnter (Collider obj)
	{
		obj.GetComponent<MoveCharacter> ().MovePattern = PowerUpTransfer.Transfer ();

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
	}
}
}
