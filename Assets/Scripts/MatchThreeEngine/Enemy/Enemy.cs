using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject TimerManager;
    public TimerSetting timerSetting;
    public int hp;
    public int attack;
    public int currentHealth;
    private Animator anim;
    public Image progressionBar;
    public Slider sliderCoba;
    public LevelPoint healthDisplay;
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

        if (currentHealth <= 50)
        {
            float fillValue = 1;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
        }
        if (currentHealth <= 25)
        {
            float fillValue = 2;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
        }

        if (currentHealth <= 0)
        {
            //anim enemy nya die
            timerSetting.CanvasMenang.SetActive(true);
            timerSetting.GameAktif = false;
            TimerManager.gameObject.SetActive(false);
            float fillValue = 3;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
        }
    }
}
