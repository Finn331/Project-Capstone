using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAdd : MonoBehaviour
{
    public SkillPoint healthDisplay;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SaveManager.instance.coin += 1;
            SaveManager.instance.Save();
        }
        else if (Input.GetKeyDown(KeyCode.F))
            SaveManager.instance.coin -= 1;
            SaveManager.instance.Save();
    }
}
