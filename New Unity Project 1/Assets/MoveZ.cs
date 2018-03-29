using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveZ : MoveBase {

	public override float Direction ()
	{
		return moveDirection.z = Input.GetAxis("Vertical");
	}


}
