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
    void Start()
    {
        mainMenuPanel.SetActive(true);
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
