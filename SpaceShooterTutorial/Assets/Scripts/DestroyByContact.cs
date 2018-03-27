using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion; 
	public GameObject PlayerExplosion;
	public Text ScoreText;
	public int Score;


	void Start ()
	{
		Score = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary") {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (PlayerExplosion, other.transform.position, other.transform.rotation);
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
		Score = Score + 10;
	}

}
