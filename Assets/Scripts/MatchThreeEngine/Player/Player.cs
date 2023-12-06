using System.Collections;
using System.Collections.Generic;
using MatchThreeEngine;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject TimerManager;
    public TimerSetting timerSetting;
    public int hp;
    public int currentHealth;
    public int attack;
    private Animator anim;
    public TileTypeAsset[] tileType; // Tambahkan ini untuk menyimpan referensi ke TileTypeAsset array

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = hp;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        attack = data.attack;
        hp = data.hp;
    }

    public void Attack(int a)
    {
        Debug.Log("attack");
        // anim.SetTrigger("player_kickT");
        TriggerAnimation(a);
        Debug.Log(a);

    }

    public void TakingDamage(int dmg)
    {
        Debug.Log("kena serang");
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {
            //anim player nya die
            timerSetting.CanvasKalah.SetActive(true);
            timerSetting.GameAktif = false;
            TimerManager.gameObject.SetActive(false);
        }
    }
    public void TriggerAnimation(int tileTypeID)
    {
        if (tileTypeID >= 1 && tileTypeID <= 5)
        {
            TileTypeAsset currentTileType = tileType[tileTypeID - 1];

            if (currentTileType != null)
            {
                // switch (currentTileType.id)
                // {
                //     case 1:
                //         anim.SetTrigger("player_kickT");
                //         Debug.Log("Tile Type 1");
                //         break;

                //     case 2:
                //         anim.SetTrigger("player_kick");
                //         Debug.Log("Tile Type 2");
                //         break;

                //     case 3:
                //         anim.SetTrigger("Animation3");
                //         Debug.Log("Tile Type 3");
                //         break;

                //     case 4:
                //         anim.SetTrigger("Animation4");
                //         Debug.Log("Tile Type 4");
                //         break;

                //     case 5:
                //         anim.SetTrigger("Animation5");
                //         Debug.Log("Tile Type 5");
                //         break;

                //     default:
                //         Debug.LogWarning($"Unhandled TileTypeAsset ID: {currentTileType.id}");
                //         break;
                // }
                anim.SetTrigger(currentTileType.animName);
                Debug.Log("Tile Type " + currentTileType.id);
                Debug.Log("Playing Anim " + currentTileType.animName);
            }
            else
            {
                Debug.LogError($"TileTypeAsset with ID {tileTypeID} is null!");
            }
        }
        else
        {
            Debug.LogError($"Invalid TileTypeID: {tileTypeID}. It should be between 1 and 5.");
        }
    }
}