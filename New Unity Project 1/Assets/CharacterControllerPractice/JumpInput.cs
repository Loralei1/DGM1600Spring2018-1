using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpInput : InputBase
{	
	public CharacterController controller;

	public override float MoveInput()
	

	{
	
		return 0;
		
		
			
	}
	
}


/*
public float FloatValue = 0;
public override float SetFloat ()
{
	return FloatValue; (For changing float values. The SetFloat function is for the 
	generic scriptable objects, which can be used to switch out inputs and values at will.)
} */
