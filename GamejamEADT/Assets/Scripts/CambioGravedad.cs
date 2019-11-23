﻿ using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    
    public float dist;

    void Start(){

        dist = GetComponent<Rigidbody2D>().gravityScale;

    }

    void Update(){

            if(dist >= 0){

                this.GetComponent<SpriteRenderer>().flipY = false;

            }
            if(dist <= 0){

                this.GetComponent<SpriteRenderer>().flipY = true;
                
            }

    }

}
