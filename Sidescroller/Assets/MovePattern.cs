using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

	public float speed = 50.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 10.0F;
	private Vector3 moveDirection = Vector3.zero;
	public InputBase InputX;
	public InputBase JumpInput;






	public void Move(CharacterController controller, Transform transform) 
	{ 

		if (controller.isGrounded) {

			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			moveDirection.x = InputX.MoveInput ();
			moveDirection.y = 0;
			moveDirection.z = 0;
			moveDirection.y = JumpInput.MoveInput ();

		}


		controller.Move(moveDirection * Time.deltaTime);
		moveDirection.y -= gravity * Time.deltaTime;


	}
}

