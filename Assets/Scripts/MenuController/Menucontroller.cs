using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menucontroller : MonoBehaviour
{

    public GameObject buttonLevelList;
    


    void Start()    
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //thêm danh sách level trong tương lai
    }
    public string GetCurrentSceneName()
    {
        return SceneManager.GetActiveScene().name;
        
    }
}
