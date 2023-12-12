using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenuManager : MonoBehaviour
{
    [Header("Setting Menu Panel List")]
    public GameObject canvas;
    public GameObject mainMenuPanel;
    public GameObject settingPanel;
    public GameObject languagesPanel;
    public GameObject audioPanel;
    public GameObject selectLevel;
    public GameObject skillPanel;
    public GameObject creditsPanel;
    public GameObject UpgradePanel;
    public GameObject pressButton;

    [Header("Setting Menu On LEVEL 1")]
    public GameObject pauseOverlay;
    public GameObject settingMenu;

    // [Header("Setting Button List")]
    // public GameObject level1;
    // public GameObject level2;
    // public GameObject level3;

    void Start()
    {
        mainMenuPanel.SetActive(true);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(AnimationManager.Instance.isLevelSelection);

        SaveManager.instance.Load();

    }

    public void closeSetting()
    {
        settingMenu.SetActive(false);
    }

    public void Level1()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }
    public void Level2()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }
    public void Level3()
    {
        skillPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void SettingButton()
    {
        mainMenuPanel.SetActive(false);
        settingPanel.SetActive(true);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }
    public void SettingButton2()
    {
        settingPanel.SetActive(true);
        pauseOverlay.SetActive(false);
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
        canvas.SetActive(true);
        mainMenuPanel.SetActive(true);
        pressButton.SetActive(false);
        settingPanel.SetActive(false);
        languagesPanel.SetActive(false);
        audioPanel.SetActive(false);
        selectLevel.SetActive(false);
    }

    public void SelectLevelButton()
    {
        // SceneManager.LoadScene("LevelSelection");
        selectLevel.SetActive(true);
        UpgradePanel.SetActive(false);
        pressButton.SetActive(false);
    }

    public void CreditsButton()
    {
        creditsPanel.SetActive(true);
    }
    
    public void CreditsButton2()
    {
        creditsPanel.SetActive(false);
    }
}
