using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject TimerManager;
    public TimerSetting timerSetting;
    public int hp;
    public int attack;
    public int currentHealth;
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

    public void EnemyAttack(/*int attack*/)
    {
        Debug.Log("Enemy Attack");
        anim.SetTrigger("enemy_kickT");
    }

    public void TakingDamage(int dmg)
    {
        Debug.Log("kena serang");
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {
            //anim enemy nya die
            timerSetting.CanvasMenang.SetActive(true);
            timerSetting.GameAktif = false;
            TimerManager.gameObject.SetActive(false);
        }
    }
}
