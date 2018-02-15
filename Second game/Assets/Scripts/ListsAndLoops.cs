using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ListsAndLoops : MonoBehaviour {
 
public TheIncredibles TheIncredibles;
public Text AddMember;

// Lists are good for collecting things. 
// Arrats are good for things you already have. 
private void OnMouseDown()
{
	TheIncredibles.FamilyList.Add(AddMember.text);
}
}


