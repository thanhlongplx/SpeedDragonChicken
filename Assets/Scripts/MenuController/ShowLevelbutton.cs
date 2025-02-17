using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowLevelbutton : MonoBehaviour
{
    public String naMe;
    LoadGameSaved show;
    void Start()
    {
        show= FindObjectOfType<LoadGameSaved>();
        naMe = GetCurrentSceneName();

        
    }
    public string GetCurrentSceneName()
    {
        return SceneManager.GetActiveScene().name;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
