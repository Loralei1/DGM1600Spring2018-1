using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveY : MoveCharacter {


	public float DirectionY ()
	{


		if (Input.GetButton("Jump"))
			moveDirection.y = jumpSpeed;

		return moveDirection.y = 0;
		
		return moveDirection.y -= gravity * Time.deltaTime;
	}
}


