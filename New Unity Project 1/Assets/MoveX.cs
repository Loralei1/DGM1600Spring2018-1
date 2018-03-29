using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveX : MoveCharacter {


	public float DirectionX ()
	{

		return moveDirection.x = Input.GetAxis ("Horizontal");
	
	}
	
}