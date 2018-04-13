using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatConstant : InputBase {

	public float FloatValue = 0;

	public override float MoveInput()
	{
		return FloatValue;
	}
}
