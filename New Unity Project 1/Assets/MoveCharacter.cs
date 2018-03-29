using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
    
    
	public CharacterController controller; 
	public MoveBase Horizontal; 
	public MoveBase Vertical;
	public MoveBase Jump;
    public MoveBase MoveBase;
    
    
   
    

    public void Start ()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update ()
    {
      MoveBase.Move(controller, transform);
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