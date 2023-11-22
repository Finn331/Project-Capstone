using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TimerSetting timerSetting;
    //public GameObject CanvasKalah;

    //hp system
    public int hp;
    public int currentHealth;

    //attack system
    public int attack;
    private Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = hp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {
        Debug.Log("attack");
        anim.SetTrigger("player_kick");
    }

    public void TakingDamage(int dmg)
    {
        Debug.Log("kena serang");
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {
            //anim player nya die
            timerSetting.CanvasKalah.SetActive(true);
            FindObjectOfType<TimerSetting>().GameAktif = false;
        }
    }
}
