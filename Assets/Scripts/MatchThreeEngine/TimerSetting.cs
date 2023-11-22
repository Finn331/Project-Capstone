using System.Collections;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Collections.Generic;


public class TimerSetting : MonoBehaviour
{
    // testing
    public Player player;
    public Enemy enemy;



    public TextMeshProUGUI TextTimer;
    [SerializeField] private float Waktu; // 01:40 (dalam detik)
    [SerializeField] private float intervalSeranganMusuh ; // Interval waktu serangan musuh dalam detik
    private float waktuTerakhirSeranganMusuh;

    public bool GameAktif = true;
    public GameObject CanvasKalah;

    private float s;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {




        // untuk mekanik musuh menyerang setiap interval waktu yang dikasih
        if (GameAktif)
        {
           
                // Cek apakah musuh harus menyerang
                if (Time.time - waktuTerakhirSeranganMusuh >= intervalSeranganMusuh)
                {
                // Musuh menyerang
                enemy.Attack();

                player.TakingDamage(enemy.attack);

                // Catat waktu serangan terakhir musuh
                waktuTerakhirSeranganMusuh = Time.time;
                }
            

           
        }



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

        
        // // Set teks pada komponen TextTimer.
        TextTimer.text = formattedTime;
    }
}