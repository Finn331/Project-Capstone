using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelPoint : MonoBehaviour
{
    public Text pointText; // Teks pada Canvas untuk menampilkan nilai fillValue

    // Fungsi ini dipanggil ketika nilai fillValue berubah

    void Update()
    {
        GetFillValue();
    }
    public void UpdateHealthDisplay(float fillValue)
    {
        pointText.text = fillValue.ToString();
    }

    // Metode untuk mengambil nilai fillValue
    public float GetFillValue()
    {
        return float.Parse(pointText.text);
    }
}