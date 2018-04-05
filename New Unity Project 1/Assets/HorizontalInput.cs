using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInput")]
public class HorizontalInput : InputBase 


{

	public string InputName = "Horizontal";
	public override float MoveInput()
	{
		return Input.GetAxis (InputName);
	}
}

//public override float SetFloat (){} option, has to return a float