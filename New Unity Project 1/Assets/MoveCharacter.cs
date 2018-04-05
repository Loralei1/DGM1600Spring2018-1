using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
    
    
	public CharacterController controller; 
    public MoveSecond MoveSecond;
    
    
   
    

    public void Start ()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update ()
    {
      MoveSecond.Move(controller, transform);
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