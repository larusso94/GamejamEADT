 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    public GameObject Player;
    public float factor, vel, gravityScale;

    void Start(){

        

    }

    void Update(){

            factor = gameObject.GetComponent<GravityController>().factor;
            vel = gameObject.GetComponent<Rigidbody2D>().velocity.y;
            if(factor >= 0 && vel <= 0){

                this.GetComponent<SpriteRenderer>().flipY = false;

            }
            if(factor <= 0 && vel >= 0){

                this.GetComponent<SpriteRenderer>().flipY = true;
                
                
            }

    }

}
