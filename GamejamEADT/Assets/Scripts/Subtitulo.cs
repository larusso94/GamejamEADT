using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitulo : MonoBehaviour
{
    public AudioClip clip;
    AudioSource audioSource;
    public GameObject SubtituloGO;
    public GameObject Textosub;
    public string Text;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
           SubtituloGO.SetActive(true);
            audioSource.PlayOneShot(clip, 0.5f);
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
