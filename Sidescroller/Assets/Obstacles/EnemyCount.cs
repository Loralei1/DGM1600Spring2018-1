using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {

	public List<GameObject> Enemies; 
	public int HitsTaken; 
	public Text HitText;
	public GameObject other;
	public GameObject AddMember;

	void Start () 

	{
		HitsTaken = 0;
		HitText.text = "Hits: ";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Rock")) {
			Enemies.Add (AddMember.gameObject);
			foreach (GameObject Enemies in Enemies)
				HitsTaken += 1;
		}
			
	}
		
	void Update () 
		{
				HitText.text = "Hits: " + HitsTaken;
		}
	


}
