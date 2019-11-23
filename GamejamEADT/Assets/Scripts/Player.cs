using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

    public float speed,forcejump;
    public bool jumpup, jumpdown;
    
    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            
        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            gameObject.transform.Translate(speed *Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpup)
        {
            
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forcejump));
            jumpup = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpdown)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -forcejump));
            jumpdown = false;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            jumpup = true;
        }
        if(collision.gameObject.tag == "techo")
        {
            jumpdown = true;
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Subtitulo");
        SetActive(true);
        "TextoSub".GetComponent<Text>.text = Text;
    }
    /*