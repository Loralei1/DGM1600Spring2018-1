using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public GameObject other;
	public Image HealthBar;
	public float PowerLevel;

	private void OnTriggerEnter (Collider obj)

	{
		HealthBar.fillAmount += PowerLevel;
		obj.GetComponent<MoveCharacter> ().Player.MovePattern = PowerUpTransfer.Transfer ();

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
	}
}
}
