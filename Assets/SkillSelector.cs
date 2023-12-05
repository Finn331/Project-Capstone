using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelector : MonoBehaviour
{
    public static SkillSelector Instance;

    public List<Button> skillButtons = new List<Button>();
    public List<Button> slotSkill = new List<Button>();

    public int selectedSlot;
    public int selectedSkill;
    public bool isSkillSelected;
    public bool isSlotSelected;

    public Sprite selectedSlotImg;
    public Sprite unselectedSlotImg;

    public string selectedSkillStr;
    public string selectedSkillStr2;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SwapSkill(int slotIndex)
    {
        selectedSlot = slotIndex - 1 + 2;
        isSlotSelected = true;
        selectedSkillStr = LevelManger.Instance.slotAnim[selectedSlot];

        int a = 0;
        foreach (var item in slotSkill)
        {
            if (a == selectedSlot)
            {
                item.image.sprite = selectedSlotImg;
            }
            else
            {
                item.image.sprite = unselectedSlotImg;
            }
            a++;
        }

    }

    public void SelectSkill(int slotIndex)
    {
        selectedSkillStr2 = LevelManger.Instance.movementAnim[slotIndex - 1];
        selectedSkill = slotIndex - 1;

        if (isSlotSelected == false)
        {
            return;
        }

        var match = LevelManger.Instance.slotAnim
            .FirstOrDefault(stringToCheck => stringToCheck.Contains(selectedSkillStr2));

        if (match == null)
        {
            Debug.Log(LevelManger.Instance.slotAnim[selectedSlot]);
            LevelManger.Instance.slotAnim[selectedSlot] = selectedSkillStr2;
        }


        // int a = 0;
        // foreach (var item in skillButtons)
        // {
        //     if (a == selectedSkill)
        //     {
        //         item.image.sprite = selectedSlotImg;
        //     }
        //     else
        //     {
        //         item.image.sprite = unselectedSlotImg;
        //     }
        //     a++;
        // }
    }
}
