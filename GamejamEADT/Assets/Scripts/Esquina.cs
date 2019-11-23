using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esquinaç : MonoBehaviour
{

    public Transform customPivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(customPivot.position, Vector3.up, 20 * Time.deltaTime);
    }
}
