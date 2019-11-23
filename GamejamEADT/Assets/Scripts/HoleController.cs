using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour
{
	[SerializeField]
	GameObject player;

	public int fuerza;
	public int D;
	void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
    	Vector2 direction = gameObject.transform.position - player.transform.position;
    	float D = direction.magnitude*direction.magnitude;
    	player.GetComponent<Rigidbody2D>().AddForce(direction/D*fuerza);
    }

} 
