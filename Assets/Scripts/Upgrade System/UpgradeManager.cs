using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyUpgrade() 
{
    if (SaveManager.instance.coin <= 2)
    {
        Debug.Log("Insufficient Coin");
        SaveManager.instance.coin += 0;
    } 
    if (SaveManager.instance.coin >= 2) 
    { 
    SaveManager.instance.coin -= 2;
    SaveManager.instance.attack += 2;
    SaveManager.instance.Save();
    }
}
}
