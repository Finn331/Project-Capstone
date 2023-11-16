using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int attack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {

    }

    public void TakingAttack(int dmg)
    {
        Debug.Log("kena serang");
        hp = hp - dmg;
    }
}
