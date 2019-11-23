using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    Animator animator;
    public float forcejump, speedmax, aceleracion, frenada;
    public bool ceil, floor;
    float playerVel;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        var player = gameObject.GetComponent<Rigidbody2D>();
        float speed = player.velocity.x;

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            if ((Mathf.Abs(speed) < speedmax) && (ceil||floor))
            {
                player.AddForce(new Vector2((-aceleracion), 0));
                if (speed > -2){

                    animator.SetBool("corriendo", true);
                }
                
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        } else if (Input.GetKey("right") || Input.GetKey("d"))
        {
            if ((speed < speedmax) && (ceil||floor))
            {
                player.AddForce(new Vector2((aceleracion), 0));
                
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                if(speed > 2){

                    animator.SetBool("corriendo", true);
                }
            }
        } else{
            if (speed < 0 && (ceil || floor))
            {

                if (speed < 2)
                {

                    animator.SetBool("corriendo", false);
                }
                
                player.AddForce(new Vector2(aceleracion, 0));

            }
            if (speed > 0 && (ceil || floor))
            {
                player.AddForce(new Vector2(-aceleracion, 0));
                if (speed < 2)
                {

                    animator.SetBool("corriendo", false);
                }
            }
            }
        
         

        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            player.AddForce(new Vector2(0, forcejump));
            floor = false;
            ceil = false;
            
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && ceil)
        {
           player.AddForce(new Vector2(0, -forcejump));
            ceil = false;
            floor = false;
            
        }
        
        if(!ceil && !floor)
        {
            animator.SetBool("Saltando", true);


        }
        else
        {
            animator.SetBool("Saltando", false);

        }

    }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "ground")
            {
                floor = true;
            }
            if (collision.gameObject.tag == "techo")
            {
                ceil = true;
            }
        }
    }