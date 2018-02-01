using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

    public bool Key;
    public int Health = 100;
    public string Password = "Swordfish";
    void Start () {
        if (Key) {
            print ("I have the key.");
		} else {
            print ("The way is shut.");
        }

        if (Health > 0) {
            print ("Can play.");
        } else {
            print ("You're dead!");
        }

        if (Password == "Swordfish") {
            print ("That is correct.");
        } else {
            print ("Try again.");
        }
    }
}