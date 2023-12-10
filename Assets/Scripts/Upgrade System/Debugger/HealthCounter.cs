using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    public TextMeshProUGUI healthCounter;
    // Start is called before the first frame update
    void Start()
    {
        healthCounter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        healthCounter.text = SaveManager.instance.health + " ";
    }
}