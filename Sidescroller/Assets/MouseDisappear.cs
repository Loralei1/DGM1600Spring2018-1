using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDisappear : MonoBehaviour {

	void OnMouseDown()
	{
		gameObject.SetActive (false);
	}
}
