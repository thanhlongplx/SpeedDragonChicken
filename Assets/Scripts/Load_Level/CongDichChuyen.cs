using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public int level_Num;
    public void LoadLevel(){
        SceneManager.LoadScene(level_Num);
    }
    
        public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            LoadLevel();          
        }
    }

    
}
