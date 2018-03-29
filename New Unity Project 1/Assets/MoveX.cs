using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveX : MoveBase {

	public override float Direction ()
	{

		return moveDirection.x = Input.GetAxis ("Horizontal");
	
	}
	
}