using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveY : MoveBase {


	public override void Direction ()
	{

		moveDirection.y = 0;
		if (Input.GetButton("Jump"))
			moveDirection.y = jumpSpeed;
		
		
	}
}


