using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left") || Input.GetKey("a"))
        {
            gameObject.transform.Translate(-speed *Time.deltaTime, 0, 0);
           //* if (Input.GetKey("right") || Input.GetKey("d"))          
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            gameObject.transform.Translate(speed *Time.deltaTime, 0, 0);
        }
        
    }
    Se
}
