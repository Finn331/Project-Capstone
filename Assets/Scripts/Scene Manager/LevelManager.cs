using MatchThreeEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // GameObject
    public GameObject PauseOverlay;
    public GameObject Effect;
    public GameObject Pause;
    public GameObject Board;

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
