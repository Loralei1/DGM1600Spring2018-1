using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlatformInput : InputBase 


{

	public float FloatValue = 1;
	public override float MoveInput()
	{
		return FloatValue;
	}
}