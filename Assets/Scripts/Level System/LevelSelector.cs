using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] lvlButton;

    // Start is called before the first frame update
    public void Update()
    {
        int levelAt = SaveManager.instance.level;

        for (int i = 0; i < lvlButton.Length; i++)
        {
            if (i + 1 <= levelAt)
                lvlButton[i].interactable = true;
            else
                lvlButton[i].interactable = false;
        }
    }


}
