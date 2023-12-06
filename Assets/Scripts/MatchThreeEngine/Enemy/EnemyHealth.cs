using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Enemy health;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = health.currentHealth;
        slider.value = fillValue;
    }
}
