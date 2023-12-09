using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    //GameObject
    

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



    public void ExitGame()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
}
