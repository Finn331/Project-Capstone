using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [Header("Main Settings")]
    public float DataFloat;
    public Slider SliderFloat;

    [Header("Condition")]
    public float ConditionFloat;
    public UnityEvent ConditionEvent;
    bool isExecuted = false;

    public void AddValue(float aValue)
    {
        DataFloat += aValue;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SliderFloat.value = DataFloat;
        if (!isExecuted)
        {
            if (ConditionFloat == DataFloat)
            {
                ConditionEvent.Invoke();
            }
        }
    }
}
