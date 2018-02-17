using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	//And this is also from Unity's Roll-a-Ball tutorial found on Unity's website.
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (15, 30, 35) * Time.deltaTime);
		
	}
}
