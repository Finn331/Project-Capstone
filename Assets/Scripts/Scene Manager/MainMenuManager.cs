using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Scene List")]
    public string levelSelect = "Level Select";
    public string loadScene = "Load Menu";

    public void GoToLoadMenu()
    {
        SceneManager.LoadScene(loadScene);
    }

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void Play()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
