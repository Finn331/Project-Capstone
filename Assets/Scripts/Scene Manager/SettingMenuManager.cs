using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenuManager : MonoBehaviour
{
    [Header("Setting Menu Panel List")]
    public GameObject mainMenuPanel;
    public GameObject settingPanel;
    public GameObject languagesPanel;
    public GameObject audioPanel;
    public GameObject selectLevel;
    public GameObject skillPanel;

    [Header("Setting Button List")]
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;


    void Start()
    {
        mainMenuPanel.SetActive(true);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void Level1()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
        level1.SetActive(true);
        level2.SetActive(false);
        level3.SetActive(false);
    }
    public void Level2()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
        level1.SetActive(false);
        level2.SetActive(true);
        level3.SetActive(false);
    }
    public void Level3()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(true);
    }

    public void SettingButton()
    {
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(true);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void LanguagesButton()
    {
        settingPanel.SetActive(false);
        languagesPanel.SetActive(true);
        selectLevel.SetActive(false);
    }

    public void AudioButton()
    {
        settingPanel.SetActive(false);
        audioPanel.SetActive(true);
        selectLevel.SetActive(false);
    }

    public void BackButton()
    {
        settingPanel.SetActive(true);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void BackToMenu()
    {
        mainMenuPanel.SetActive(true);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void SelectLevelButton()
    {
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(true);
    }
}
