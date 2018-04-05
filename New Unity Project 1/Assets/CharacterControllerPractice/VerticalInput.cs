using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class VerticalInput : InputBase 
{
	public override float MoveInput()
	{
		return Input.GetAxis("Vertical");
	}
	
}
