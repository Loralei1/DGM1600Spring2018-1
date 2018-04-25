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
	public Transform transform;
	public Text GameOverText;

	void Start ()
	{
		GameOverText.text = "";
	}

	private void OnTriggerEnter (Collider obj)

	{
		HealthBar.fillAmount += PowerLevel;

		if (HealthBar.fillAmount <= 0) 
		{
			obj.GetComponent<MoveCharacter> ().Player.MovePattern = PowerUpTransfer.Transfer ();
			GameOverText.text = "Game Over.";

		}


		if (HealthBar.fillAmount > 0) {
			for (int i = 0; i < 1; i++) {
				Instantiate (Enemy, transform.position, transform.rotation);
			}


		} 
	}
}

