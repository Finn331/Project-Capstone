using System.Collections;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TimerSetting : MonoBehaviour
{
    public TextMeshProUGUI TextTimer;
    [SerializeField] private float Waktu = 100; // 01:40 (dalam detik)

    private bool GameAktif = true;
    public GameObject CanvasKalah;

    private float s;

    private void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Kalah");
            CanvasKalah.SetActive(true);
            GameAktif = false;
        }

        SetText();
    }

    private void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);

        // Format Menit dan Detik menjadi teks sesuai dengan kebutuhan (misalnya, menampilkan "01:40").
        string formattedTime = string.Format("{0:00}:{1:00}", Menit, Detik);

        //Bang gua ga ngerti buat set tiap 5 detik enemy nya bakal nyerang (emot batu)
        // if (Detik % 5 == 0)
        //     {
                 
        //     }
        // // Set teks pada komponen TextTimer.
        TextTimer.text = formattedTime;
    }
}
