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
	private enum HitNumber {First, Second, Third, Fourth};
	// Use this for initialization
	void Start () 

	{
		HitsTaken = 0;
		HitText.text = "Hits: ";
		HitNumber MyHitNumber;
		MyHitNumber = HitNumber.First;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Rock")) {
			Enemies.Add (AddMember.gameObject);
			foreach (GameObject Enemies in Enemies)
				HitsTaken += 1;
		}
			
	}

	
	// Update is called once per frame
	void Update () 
		{
				HitText.text = "Hits: " + HitsTaken;
		}
	


}
