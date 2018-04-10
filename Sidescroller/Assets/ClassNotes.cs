using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassNotes : MonoBehaviour {

	/*Notes on stuff for the final

	For powerups, you need a MonoBehavior and a ScriptableObject
	
	Triggers and transfer: 
	
	public PowerUp PowerUpTransfer;
	
	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();


	} 

	public class PowerUp : ScriptableObject
	{
		
		public MovePattern MovePattern; (This way the powerup will hold a movepattern)
	}
	
	public class Trigger : MonoBehavior
	
	
	public PowerUp PowerUp' 
	private MoveCharacter prevMoveCharacter;
	private float TimeToRestore = 2;

	void OnTriggerEnter (Collider obj)
	{	
		(for storing move pattern:
		prevMovePattern = obj.GetComponent<MoveCharacter>();
		prevMovePattern = prevMoveCharacter.MovePattern;
		
		 Sets to the previous 
		movepattern. )
		obj.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;

		(
			invoke("RestoreMovePattern", TimeToRestore);

			gameObject.SetActive(false);
			
			void RestoreMovePattern()
		{
			prevMoveCharacter.MovePattern = prevMovePattern;
		})

		gameObject.SetActive(false); turns it off/kills the thing 

		speed boost powerup: Use power up with fast move pattern. For slow speed boost, 
		use powerup with slow move pattern. You can also use it to give a player
		the ability to jump. Memo to me: Add a jump add PowerUp at the beginning of the 
		game. Can I do a color change power up? turns out yes. (still remember to attach both 
		scriptable objects)

		How to make PowerUp temporary:

		Put the script on the PowerUp 



		make sure to attach the correct scriptableobjects in the correct places
	}*/
}
