using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayPoint : MonoBehaviour
{
    public TextMeshProUGUI coin;
    public LevelPoint levelPoint; // Referensi ke skrip SkillPoint

    void Start()
    {
        // Contoh penggunaan: Mengambil nilai fillValue dari SkillPoint
        float fillValue = levelPoint.GetFillValue();
        Debug.Log("FillValue: " + fillValue);
    }
}
