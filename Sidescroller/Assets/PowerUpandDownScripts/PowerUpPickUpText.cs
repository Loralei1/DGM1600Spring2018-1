using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpPickUpText : MonoBehaviour {

	public Text PickUpText;
	public string[] PickUpName;
	public GameObject[] PickUp;

	void Start()
	{
		SetPickUpText ();
	}



	void OnTriggerEnter (Collider other) 
	{
		foreach (var PickUp in PickUp)
		{
			Instantiate(PickUpText); 
		}

		//if (other.gameObject.CompareTag ("Coin")) 
		//{
			//other.gameObject.SetActive (false);
			//Score = Score + 1;
			//SetScoreText ();
		//}

	}

	void SetPickUpText ()
	{
		PickUpText.text = "You picked up " + PickUpName + ".";

	}


}/*using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
	public Transform prefab;
	void Start()
	{
		for (int i = 0; i < 10; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}
	}
}

}*/
