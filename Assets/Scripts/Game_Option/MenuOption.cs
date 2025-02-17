using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOption : MonoBehaviour
{
    private String HowToPlay = "HowToPlay";
    private String Story = "Intro";
    private String Menu = "Menu";
    UIVideo UIV;
    Move gaLong;
    void Start()
    {
        gaLong = FindObjectOfType<Move>();
        pt = FindObjectOfType<point>();
        pt.isTrue = true;
        UIV = FindObjectOfType<UIVideo>();
    }

    void Update()
    {
        UI = FindObjectOfType<UIManager>();
    }
    public GameObject scrollBar;
    UIManager UI;
    point pt;
    public void PlayNew()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(Menu);
    }
    public void Load_HowToPlay()
    {
        SceneManager.LoadScene(HowToPlay);
    }
    public void Load_Intro()
    {
        SceneManager.LoadScene(Story);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
    public void GoToVietnamese()
    {
        scrollBar.transform.position = new Vector3(-0.07f, -110.02f, 0.02616105f);
    }
    public void GoToEnglish()
    {
        scrollBar.transform.position = new Vector3(-0.07f, 4.39f, 0.02616105f);
    }

    public void showPauseMenu()
    {
        UI.ShowPauseGameMenu(true);
        UI.showPauseMenu = true;
    }
    public void hidePauseMenu()
    {
        UI.ShowPauseGameMenu(false);
        UI.showPauseMenu = false;

    }
    public void showRequestMenu()
    {
        UI.showRequestMenu(true);
        UI.showPauseMenu = true;
    }
    public void hideRequestMenu()
    {
        UI.showRequestMenu(false);
        UI.showPauseMenu = false;
    }
    // Set up cho level6
    public void showKeyPannel()
    {
        UI.showKeyPannel(true);
        UI.showPauseMenu = true;
    }
    public void hideKeyPannel()
    {
        UI.showKeyPannel(false);
        UI.showPauseMenu = false;
    }
    public void showHuongDanLevel7Pannel()
    {
        UI.showHuongDanLevel7Pannel(true);// cần chỉnh sửa
        UI.showPauseMenu = true;
    }
    public void showDaquyPannel()
    {
        UI.showDaquyPannel(true);// cần chỉnh sửa
        UI.showPauseMenu = true;
    }
    public void hideHuongDanLevel7Pannel()
    {
        UI.showHuongDanLevel7Pannel(false);
        UI.showPauseMenu = false;
    }
    public void hideHuongDanLevel8Pannel()
    {
        UI.showHuongDanLevel8Pannel(false);
        UI.showTFText(true);
        UI.showPauseMenu = false;
    }
    public void hideDaquyPannel()
    {
        UI.showDaquyPannel(false);
        UI.showPauseMenu = false;
    }

    public void hideFirstPannel()
    {
        UI.showFirstPannel(false);
        UI.showPauseMenu = false;
    }
    public void showTruAnhSangRequestPannel()
    {
        UI.showTruAnhSangRequestPannel(true);
        UI.showPauseMenu = true;
    }
    public void hideTruAnhSangRequestPannel()
    {
        UI.showTruAnhSangRequestPannel(false);
        UI.showPauseMenu = false;
    }

    public void showKichHoatCongDichChuyenPannel()
    {
        UI.showKichHoatCongDichChuyenPannel(true);
        UI.showPauseMenu = true;
    }
    public void hideKichHoatCongDichChuyenPannel()
    {
        UI.showKichHoatCongDichChuyenPannel(false);
        UI.showPauseMenu = false;
    }
    //set up cho level 8
    public void showBook1Pannel()
    {
        UI.showBook1Pannel(true);
        UI.showPauseMenu = true;
        UI.ShowPauseButton(false);
    }
    public void hideBook1Pannel()
    {
        UI.showBook1Pannel(false);
        UI.showPauseMenu = false;
        UI.ShowPauseButton(true);
        if (pt.isTrue)
        {
            pt.point_lv8++;
        }

    }
    public void showBook2Pannel()
    {
        UI.showBook2Pannel(true);
        UI.showPauseMenu = true;
        UI.ShowPauseButton(false);
    }
    public void hideBook2Pannel()
    {
        UI.showBook2Pannel(false);
        UI.showPauseMenu = false;
        UI.ShowPauseButton(true);
        if (pt.isTrue)
        {
            pt.point_lv8++;
        }

    }
    public void showBook3Pannel()
    {
        UI.showBook3Pannel(true);
        UI.showPauseMenu = true;
        UI.ShowPauseButton(false);

    }

    public void hideBook3Pannel()
    {
        UI.showBook3Pannel(false);
        UI.showPauseMenu = false;
        UI.ShowPauseButton(true);
        if (pt.isTrue)
        {
            pt.point_lv8++;
        }

    }

    public void showBook4Pannel()
    {
        UI.showBook4Pannel(true);
        UI.showPauseMenu = true;
        UI.ShowPauseButton(false);


    }
    public void hideBook4Pannel()
    {
        UI.showBook4Pannel(false);
        UI.showPauseMenu = false;
        UI.ShowPauseButton(true);
        if (pt.isTrue)
        {
            pt.point_lv8++;
        }
    }
    public void heartDown()
    {
        pt.isTrue = false;
        gaLong.heart--;
        pt.false_time++;
        hideBook2Pannel();
        hideBook1Pannel();
        hideBook3Pannel();
        hideBook4Pannel();
        pt.isTrue = true;
        UI.ShowPauseButton(true);
    }

    public void showGoiYPannel()
    {
        UIV.showGoiYPannel(true);
    }
    public void hideGoiYPannel()
    {
        UIV.showGoiYPannel(false);
    }
    // Load levelList
    public void showLevelList(){
        UI.showLoadLevelListButton(true);
    }
}
