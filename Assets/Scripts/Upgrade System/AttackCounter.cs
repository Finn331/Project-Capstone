using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AttackCounter : MonoBehaviour
{
    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    private void Awake()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = SaveManager.instance.attack + " ";
    }
}