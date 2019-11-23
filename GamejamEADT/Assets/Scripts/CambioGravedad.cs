 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    public GameObject Player;
    public float dist;
    public float gravityScale;

    void Start(){

        

    }

    void Update(){

dist = gameObject.GetComponent<GravityController>().factor;
            if(dist >= 0){

                this.GetComponent<SpriteRenderer>().flipY = false;

            }
            if(dist <= 0){

                this.GetComponent<SpriteRenderer>().flipY = true;
                
            }

    }

}
