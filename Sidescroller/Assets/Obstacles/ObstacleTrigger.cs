using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleTrigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public GameObject other;
	public Image HealthBar;
	public float PowerLevel;
	public GameObject Enemy;

	private void OnTriggerEnter (Collider obj)

	{
		HealthBar.fillAmount += PowerLevel;
		obj.GetComponent<MoveCharacter> ().MovePattern = PowerUpTransfer.Transfer ();

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);

			for (int i = 0; i < 1; i++) 
			{
				Instantiate(Enemy);
			}

	}
}
}
