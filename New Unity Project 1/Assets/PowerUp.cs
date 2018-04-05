using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : ScriptableObject 
{
	public int PowerLevel;

	public movePattern MovePatternTransfer;

	public MovePattern Transfer ()
	{
		return MovePatternTransfer
	}
}
