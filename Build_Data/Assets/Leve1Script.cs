﻿using UnityEngine;
using System.Collections;

public class Leve1Script : MonoBehaviour {

    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        //if the object that triggered the event is tagged player
        if (other.tag == "Player")
        {
            //Application.LoadLevel(1);
            Application.LoadLevel(2);
        }

        //		if (other.gameObject.transform.parent) {
        //			Destroy (other.gameObject.transform.parent.gameObject);
        //			
        //		} else {
        //			Destroy (other.gameObject);		
        //		}
    }
}
