using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillPoint : MonoBehaviour
{
    public Text healthText; // Teks pada Canvas untuk menampilkan nilai fillValue

    // Fungsi ini dipanggil ketika nilai fillValue berubah

    void Update()
    {
        GetFillValue();
    }
    public void UpdateHealthDisplay(float fillValue)
    {
        healthText.text = fillValue.ToString();
    }

    // Metode untuk mengambil nilai fillValue
    public float GetFillValue()
    {
        return float.Parse(healthText.text);
    }
}
