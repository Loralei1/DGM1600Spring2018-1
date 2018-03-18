using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CaeserPlus3 : Cipher {

	public override string FinishCipher()
	{
		
		return Input(1, Input.Length + 3);
	}

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
	 */ 
	 
