using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	public CharacterController controller; 
	public MovePattern MovePattern;
	



	public void Start ()
	{
		controller = GetComponent<CharacterController>(); 
	}

	void Update ()
	{
		MovePattern.Move(controller, transform);
	} 
}
