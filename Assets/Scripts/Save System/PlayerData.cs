using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int attack;
    public int hp;
    //public int level;
    public PlayerData (Player player)
    {
        attack = player.attack;
        hp = player.hp;

    }
}
