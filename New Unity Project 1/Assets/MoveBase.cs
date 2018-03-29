using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MoveBase : ScriptableObject {

	protected float speed = 6.0F;
	protected float jumpSpeed = 8.0F;
	protected float gravity = 10.0F;
	protected Vector3 moveDirection = Vector3.zero;
	  
	




	public void Move(CharacterController controller, Transform transform) 
	{ 

		if (controller.isGrounded) {

		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
       

        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;

            

		Direction ();
	}
}
	public abstract void Direction ();
} //ScriptableObjectFireflyVideo