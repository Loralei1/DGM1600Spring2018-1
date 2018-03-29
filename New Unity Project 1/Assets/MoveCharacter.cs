using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 10.0F;
	public Vector3 moveDirection = Vector3.zero;
    public CharacterController controller; 
	public string Horizontal; 
	public string Vertical;
	public string Jump;

    public void Start ()
    {
        controller = GetComponent<CharacterController>(); 
    }

    
    void Update ()
	{
        
		if (controller.isGrounded) {

			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

		}
	
		controller.Move(moveDirection * Time.deltaTime);

	}
}

           /* moveDirection.y = 0;
            moveDirection.z = Input.GetAxis("Vertical");
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

}
*/