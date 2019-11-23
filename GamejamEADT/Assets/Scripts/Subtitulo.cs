using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitulo : MonoBehaviour
{
    public GameObject SubtituloGO;
    public GameObject Textosub;
    public string Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
           SubtituloGO.SetActive(true);
            
            Textosub.GetComponent<Text>().text = Text;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            SubtituloGO.SetActive(false);
        }
        
    }

}
