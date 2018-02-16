using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ListsAndLoops : MonoBehaviour {
 
public TheIncredibles TheIncredibles;
public Text AddMember;

// Lists are good for collecting things. 
// Arrays are good for things you already have.
/* Lists function similarly to arrays. The primary difference is that arrays are used for 
   a collection of data in a single type intended to stay the same throughout a game, while lists
   are used for a collection of data in a single type intended to change throuhout a game. 
   A list is declared with enclosed carrots; for example,we could create a list in a script titled "Hobbits" that would go; public List<string> HobbitList; This list can be called to in another script in order to 
   do work. So, in order to access the HobbitList script, we would write create public variables and write a function. For example:

	public Hobbits Hobbits; 
	public String AddHobbit;

	private void Start ();

	Hobbits.HobbitList.Add(AddMember.string);

	Any data added during gameplay would be deleted once game play has stopped. In order to make additions permanent, we would have to create a scriptable object. 

	Lists use the System.Collections.Generic; class. This has to be present in order for a list to function. */

private void OnMouseDown()
{
	TheIncredibles.FamilyList.Add(AddMember.text);
}
}


