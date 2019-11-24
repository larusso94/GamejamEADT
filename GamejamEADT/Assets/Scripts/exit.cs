using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject fadeIn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){

            fadeIn.GetComponent<Animator>().SetBool("Final", true);
            Application.Quit();
            

        }
    }
}
