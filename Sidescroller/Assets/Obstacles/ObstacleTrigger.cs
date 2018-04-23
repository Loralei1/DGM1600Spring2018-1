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

	private void OnTriggerEnter (Collider obj)

	{
		HealthBar.fillAmount += PowerLevel;
		obj.GetComponent<MoveCharacter> ().MovePattern = PowerUpTransfer.Transfer ();


		for (int i = 0; i < 1; i++) 
			{
				Instantiate(Enemy, transform.position, transform.rotation);
			}

	}
}

