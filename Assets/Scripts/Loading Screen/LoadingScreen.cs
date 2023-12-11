using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider LoadingSlider;
    public Text TextLoading;
    public Button LoadLevelButton;

    private float _progress = 0f;
    private bool _isClicked = false;

    public void OnLoadLevelClick(string sceneName)
    {
        loadingScreen.SetActive(true);

        //disable Button to prevent double cliks
        LoadLevelButton.interactable = false;

        StartCoroutine(LoadAsync(sceneName));
    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        operation.allowSceneActivation = false;

        while (_progress < 1)
        {
            _progress = Mathf.Clamp01(operation.progress / 0.9f);
            LoadingSlider.value = _progress;
            //fill.fillAmount = _progress;
            TextLoading.text = "Loading... " + (int)(_progress * 100f) + "%";
            yield return null;
        }

        TextLoading.text = "Click Anywhere to Start.";

        while (!_isClicked)
        {
            yield return null;
        }

        operation.allowSceneActivation = true;
    }

    private void Update()
    {
        if(Input.GetMouseButtonUp(0) && _progress == 1)
        {
            _isClicked = true;
        }
    }
}
