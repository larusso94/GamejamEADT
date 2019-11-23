 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    
void OnCollisionEnter2D(Collision2D other){

    if(other.gameObject.tag == "suelo"){

        this.GetComponent<SpriteRenderer>().flipY = false;

    }
        if(other.gameObject.tag == "techo"){

        this.GetComponent<SpriteRenderer>().flipY = true;

    }

}

}
