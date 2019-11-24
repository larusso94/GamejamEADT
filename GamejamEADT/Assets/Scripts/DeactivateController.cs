using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other){
    	if (other.gameObject.tag == "Player"){
    		other.gameObject.GetComponent<Player>().enabled = false;
    		other.gameObject.GetComponent<Animator>().SetBool("corriendo", false);
    		other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
    	}
    }
}
