using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InputZ : InputBase 


{

	public string InputName = "Vertical";
	public float FloatValue = 5;
	public override float MoveInput()
	{
		return Input.GetAxis (InputName);
	}
}
