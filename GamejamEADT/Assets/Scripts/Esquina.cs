using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esquina : MonoBehaviour
{

    public Transform customPivot;
    public Transform mapa;
    bool rotate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && rotate == false){
            mapa.transform.RotateAround(customPivot.position, Vector3.back, -90);
            rotate = true;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && rotate == true){
            rotate = false;
        }
        
    }
}
