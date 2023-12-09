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
    public SkillPoint healthDisplay;

    private bool addedValue50 = false;
    private bool addedValue25 = false;
    private bool addedValue0 = false;

    public int storedCoinWin;
    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = hp;


        int randomAnimIndex = Random.Range(0, 3);

        switch (SaveManager.instance.levelSelected)
        {
            case 1:
                attack = 2;
                break;
            case 2:
                attack = 20;
                break;
            case 3:
                attack = 30;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void EnemyAttack(/*int attack*/)
    {
        // Debug.Log("Enemy Attack");
        anim.SetTrigger("enemy_kickT");
    }

    public void TakingDamage(int dmg)
    {
        Debug.Log("kena serang");
        currentHealth -= dmg;

        if (currentHealth <= 50 && !addedValue50)
        {
            float fillValue = 1;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
            storedCoinWin += 1;


            // Set addedValue50 menjadi true agar tidak ditambahkan lagi
            addedValue50 = true;
        }
        else if (currentHealth <= 25 && !addedValue25)
        {
            float fillValue = 2;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
            storedCoinWin += 1;

            // Set addedValue25 menjadi true agar tidak ditambahkan lagi
            addedValue25 = true;
        }
        else if (currentHealth <= 0 && !addedValue0)
        {
            // anim enemy nya die
            timerSetting.CanvasMenang.SetActive(true);
            timerSetting.GameAktif = false;
            TimerManager.gameObject.SetActive(false);
            float fillValue = 3;
            sliderCoba.value = fillValue;
            healthDisplay.UpdateHealthDisplay(fillValue);
            storedCoinWin += 1;

            SaveManager.instance.coin += storedCoinWin;
            SaveManager.instance.level += 1;
            SaveManager.instance.Save();

            // Set addedValue0 menjadi true agar tidak ditambahkan lagi
            addedValue0 = true;
        }
    }
}