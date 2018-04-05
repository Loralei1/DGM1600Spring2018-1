using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveSecond : ScriptableObject {

	public float speed = 20.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 10.0F;
	private Vector3 moveDirection = Vector3.zero;
	public InputBase InputX;
	public InputBase InputZ;
	public InputBase InputY;
	  
	




	public void Move(CharacterController controller, Transform transform) 
	{ 

		if (controller.isGrounded) {

		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		moveDirection.x = InputX.MoveInput ();
		moveDirection.y = InputX.MoveInput ();
		moveDirection.z = InputZ.MoveInput ();
		moveDirection.y = jumpSpeed;
			if (Input.GetButton("Jump"));
		
		}
       

        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;

            
}
}
