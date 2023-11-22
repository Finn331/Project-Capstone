using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 100;
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

    public void Attack(int attack)
    {
        Debug.Log("Enemy Attack");
        anim.SetTrigger("player_kick");
    }

    public void TakingDamage(int dmg)
    {
        Debug.Log("kena serang");
        currentHealth -= dmg;

        if(currentHealth <= 0)
        {
            //anim player nya die
        }        
    }
}
