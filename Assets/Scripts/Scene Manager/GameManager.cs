using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // GameObject
    public GameObject PauseOverlay;
    public GameObject Effect;
    public GameObject Pause;
    public GameObject Board;

    public static GameManager Instance;



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
        SceneManager.LoadScene("Main Menu");
    }

    public void Level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");
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

    public void ResumeUI()
    {
        Pause.SetActive(true);
        PauseOverlay.SetActive(false);
        Effect.SetActive(false);
        Time.timeScale = 1f;
        Board.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
   
}
