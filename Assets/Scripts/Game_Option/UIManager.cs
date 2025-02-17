using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public bool showPauseMenu;
    public bool isHasKey = false;

    

    public GameObject ReQuestMenu;
    public GameObject FirstPannel;
    public GameObject thongBaoGaLuaPannel;

    public GameObject GameoverPannel;
    public GameObject PauseButton;
    public GameObject PausePannel;
    public GameObject KeyPannel;
    public GameObject DaquyPannel;
    public GameObject TruAnhSangRequestPannel;
    public GameObject KichHoatCongDichChuyenPannel;
    public GameObject HuongDanLevel7Pannel;
    public GameObject HuongDanLevel8Pannel;
    public GameObject Book1Pannel;
    public GameObject Book2Pannel;
    public GameObject Book3Pannel;
    public GameObject Book4Pannel;

    public GameObject TFTextT;
    public GameObject TFTextF;
    public GameObject TFTexttt;
    public GameObject TFTexttf;

    public GameObject ContinueButton;
    public TextMeshProUGUI RespawnText;

    public GameObject LevelListButton;
    public void showGameoverPannel(bool isShow)
    {
        GameoverPannel.SetActive(isShow);
    }
    public void ShowContinue(bool isShow)
    {
        ContinueButton.SetActive(isShow);
    }
    public void ShowPauseButton(bool isShow)
    {
        PauseButton.SetActive(isShow);
    }
    public void ShowPauseGameMenu(bool isShow)
    {
        PausePannel.SetActive(isShow);
    }
    public void UpdateRespawnText(int gameControllerRespawns)
    {
        RespawnText.SetText("You have " + gameControllerRespawns + " respawns");
    }
    public void showRequestMenu(bool isShow)
    {
        ReQuestMenu.SetActive(isShow);
    }
    public void showFirstPannel(bool isShow)
    {
        FirstPannel.SetActive(isShow);
    }

    public void showthongBaoGaLua(bool isShow)
    {
        thongBaoGaLuaPannel.SetActive(isShow);
    }
    // Set up cho level6
    public void showKeyPannel(bool isShow)
    {
        KeyPannel.SetActive(isShow);
    }
    //Set up cho level 7
    public void showHuongDanLevel7Pannel(bool isShow)
    {
        HuongDanLevel7Pannel.SetActive(isShow);
    }
    public void showHuongDanLevel8Pannel(bool isShow)
    {
        HuongDanLevel8Pannel.SetActive(isShow);
    }
    public void showDaquyPannel(bool isShow)
    {
        DaquyPannel.SetActive(isShow);
    }
    public void showTruAnhSangRequestPannel(bool isShow)
    {
        TruAnhSangRequestPannel.SetActive(isShow);
    }
    public void showKichHoatCongDichChuyenPannel(bool isShow)
    {
        KichHoatCongDichChuyenPannel.SetActive(isShow);
    }
    //set up cho level 8
    public void showBook1Pannel(bool isShow)
    {
        Book1Pannel.SetActive(isShow);
    }
    public void showBook2Pannel(bool isShow)
    {
        Book2Pannel.SetActive(isShow);
    }
    public void showBook3Pannel(bool isShow)
    {
        Book3Pannel.SetActive(isShow);
    }
    public void showBook4Pannel(bool isShow)
    {
        Book4Pannel.SetActive(isShow);
    }
    public void showTFText(bool isShow)
    {
        TFTextT.SetActive(isShow);
        TFTextF.SetActive(isShow);
        TFTexttt.SetActive(isShow);
        TFTexttf.SetActive(isShow);
    }

    // Load levelList
    public void showLoadLevelListButton(bool isShow){
        LevelListButton.SetActive(isShow);
    }








}
