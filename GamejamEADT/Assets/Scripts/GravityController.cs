﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
	[SerializeField]
	GameObject player;
	[SerializeField]
	GameObject ceil;
	[SerializeField]
	GameObject ground;
     
     float ceilPos;
     float groundPos;
     float D;

   void Start()
    {
    	ceilPos = ceil.transform.position.y - ceil.GetComponent<BoxCollider2D>().size.y/2;
    	groundPos = ground.transform.position.y + ground.GetComponent<BoxCollider2D>().size.y/2;
        D  = ceilPos - groundPos;

    }

    // Update is called once per frame
    void Update()
    {
    	ceilPos = ceil.transform.position.y - ceil.GetComponent<BoxCollider2D>().size.y/2;
    	groundPos = ground.transform.position.y + ground.GetComponent<BoxCollider2D>().size.y/2;
    	float d1 = player.transform.position.y - groundPos;
    	float d2 = ceilPos - player.transform.position.y;
    	float factor = (d2 - d1)/D;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = factor;
    }
}
