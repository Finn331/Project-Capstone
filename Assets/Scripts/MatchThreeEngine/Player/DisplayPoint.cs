using UnityEngine;

public class DisplayPoint : MonoBehaviour
{
    public SkillPoint skillPoint; // Referensi ke skrip SkillPoint

    void Start()
    {
        // Contoh penggunaan: Mengambil nilai fillValue dari SkillPoint
        float fillValue = skillPoint.GetFillValue();
        Debug.Log("FillValue: " + fillValue);
    }
}
