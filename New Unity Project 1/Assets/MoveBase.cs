using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 10.0F;
	protected Vector3 moveDirection = Vector3.zero;
	protected CharacterController controller; 




	public string Move() 
	{

		moveDirection *= speed;	
		controller.Move(moveDirection * Time.deltaTime);

		return Direction ();
	}

	public abstract float Direction ();
}