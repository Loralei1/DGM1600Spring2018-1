using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveZ : MoveCharacter {


	public float DirectionZ ()
	{
		return moveDirection.z = Input.GetAxis("Vertical");
	}


}
