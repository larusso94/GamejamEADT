 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class CambioGravedad : MonoBehaviour
{

    public GameObject Player;
    float dist;

    void Start(){

        dist = Player.GetComponent<GravityController>.D;

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
