﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void NewGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
