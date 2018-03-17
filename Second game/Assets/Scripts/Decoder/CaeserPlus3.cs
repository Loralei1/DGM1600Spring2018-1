using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeserPlus3 : ScriptableObject {

	public override string FinishCipher()
	{
		
		return (Input++);
	}

	/* 
	 * for CaesarMinus3: 
	 * 
	 * public class CaesarMinus3 : Cipher {
	 * public override string FinishCipher()
	 * {
	 * return (Input--);
	 * }
	 * }
		
for AtbashEncode: 
	 * 
	 * public class AtbashEncode : Cipher {
	 * public override string FinishCipher()
	 * {
	 * return (Input += 26);
	 * }
	 * }
}

AtbashDecode: 
	 * 
	 * public class AtbashDecode : Cipher {
	 * public override string FinishCipher()
	 * {
	 * return (Input -= 26);
	 * }
	 * }
