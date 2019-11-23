 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    void Update(){

if(Input.GetKeyDown(KeyCode.W)){

        this.GetComponent<Rigidbody2D>().gravityScale = -1;

}
if(Input.GetKeyDown(KeyCode.S)){

        this.GetComponent<Rigidbody2D>().gravityScale = 1;

}

    }

    
void OnCollisionEnter2D(Collision2D other){

    if(other.gameObject.tag == "suelo"){

        this.GetComponent<SpriteRenderer>().flipY = false;

    }
        if(other.gameObject.tag == "techo"){

        this.GetComponent<SpriteRenderer>().flipY = true;

    }

}

}
