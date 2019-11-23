using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

    public float speed, forcejump, speedmax, aceleracion, frenada;
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
            if ((speed < speedmax) && (jumpup || jumpdown))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2((-speed - aceleracion), 0));
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            if ((speed < speedmax) && (jumpup || jumpdown))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2((speed + aceleracion), 0));
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
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
            if (collision.gameObject.tag == "ground")
            {
                jumpup = true;
            }
            if (collision.gameObject.tag == "techo")
            {
                jumpdown = true;
            }
        }
    }