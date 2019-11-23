using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiartecho : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag == "techo"){

			Player.GetComponent<GravityController>().ceil = other.gameObject;

		}
}
}
