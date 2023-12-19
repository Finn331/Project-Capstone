using MatchThreeEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // GameObject
    public GameObject PauseOverlay;
    public GameObject Effect;
    public GameObject Pause;
    public GameObject Board;
    public GameObject HolderSettingPanel;
    public GameObject HolderAudioPanel;

    public static LevelManager Instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Scene Loader
    public void BackToMenu()
    {
        Time.timeScale = 1;
        AnimationManager.Instance.isLevelSelection = false;
        SceneManager.LoadScene("Main Menu");
    }

    public void BackTolevelselection()
    {
        Time.timeScale = 1;
        AnimationManager.Instance.isLevelSelection = true;
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level " + SaveManager.instance.level);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level " + SaveManager.instance.levelSelected);
    }

    // UI
    public void PauseUI()
    {
        //Pause.SetActive(false);
        PauseOverlay.SetActive(true);
        Effect.SetActive(true);
        Time.timeScale = 0f;
        Board.SetActive(false);
    }

    public void PauseUI2()
    {
        //Pause.SetActive(false);
        PauseOverlay.SetActive(true);
        Effect.SetActive(true);
        Time.timeScale = 0f;
        Board.SetActive(false);
        HolderSettingPanel.SetActive(false);
    }

    public void ResumeUI()
    {
        Pause.SetActive(true);
        HolderSettingPanel.SetActive(false);
        HolderAudioPanel.SetActive(false);
        PauseOverlay.SetActive(false);
        Effect.SetActive(false);
        Board.SetActive(true);
        Time.timeScale = 1f;
    }

    public void SettingUI()
    {
        PauseOverlay.SetActive(false);
        HolderSettingPanel.SetActive(true);
        HolderAudioPanel.SetActive(false);
        Board.SetActive(false);
        Time.timeScale = 0f;

    }

    public void AudioUI()
    {
        HolderAudioPanel.SetActive(true);
        HolderSettingPanel.SetActive(true);
        PauseOverlay.SetActive(false);
        Board.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
