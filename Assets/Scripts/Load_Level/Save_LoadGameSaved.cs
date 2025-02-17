using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameSaved : MonoBehaviour
{

    int scene_saved;
    private String Menu = "Menu";
    private String LevelList = "LevelList";
    int scene_index;
    private String Level1 = "Level1";
    

    private String Level2 = "Level2";
    

    private String Level3 = "Level3";
    

    private String Level4 = "Level4";
    

    private String Level5 = "Level5";
    

    private String Level6 = "Level6";
    

    private String Level7 = "Level7";
    

    private String Level8 = "Level8";
    
    
    public void Load_Saved_Scence()
    {
        scene_saved = PlayerPrefs.GetInt("Saved", -1);
        if (scene_saved >= 0)
        {
            SceneManager.LoadSceneAsync(scene_saved).completed += OnSceneLoadCompleted;
        }
        else
        {
            return;
        }
    }

    private void OnSceneLoadCompleted(AsyncOperation operation)
    {
        // Khôi phục trạng thái SetActive cho các GameObject
        GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (var obj in gameObjects)
        {
            if (PlayerPrefs.HasKey(obj.name))
            {
                int activeValue = PlayerPrefs.GetInt(obj.name);
                obj.SetActive(activeValue == 1);
            }
        }
    }

    // load all
    public void Save_and_Exit()
    {
        // Lưu chỉ số scene hiện tại
        scene_index = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", scene_index); // Lưu số scene

        // Lưu trạng thái SetActive của các GameObject
        GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var obj in gameObjects)
        {
            // Chỉ lưu trạng thái cho các GameObject không bị ẩn (active in hierarchy)
            if (obj.activeInHierarchy)
            {
                PlayerPrefs.SetInt(obj.name, obj.activeSelf ? 1 : 0);
            }
        }

        PlayerPrefs.Save(); // Lưu vào bộ nhớ trên máy
        SceneManager.LoadScene(Menu); // Load scene Menu
    }
    public void nextScene()
    {
        scene_index = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadSceneAsync(scene_index);
    }

    public void loadLevelList()
    {
        SceneManager.LoadScene(LevelList);

    }

    public void loadLevel1()
    {

            SceneManager.LoadScene(Level1);
        
    }

    public void loadLevel2()
    {

            SceneManager.LoadScene(Level2);
        
    }

    public void loadLevel3()
    {

            SceneManager.LoadScene(Level3);
        
    }

    public void loadLevel4()
    {

            SceneManager.LoadScene(Level4);

    }

    public void loadLevel5()
    {

            SceneManager.LoadScene(Level5);
        
    }

    public void loadLevel6()
    {

            SceneManager.LoadScene(Level6);
        
    }

    public void loadLevel7()
    {

            SceneManager.LoadScene(Level7);
    }

    public void loadLevel8()
    {

            SceneManager.LoadScene(Level8);
    }
}
