using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{
  public static SaveManager instance {  get; private set; }

    //what we want to save
    public int coin;


    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
        instance = this; 

        DontDestroyOnLoad(gameObject);
        Load();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            coin = data.coin;

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

        data.coin = coin;

        bf.Serialize(file, data);
        file.Close();
    }

    //dont forget add this too from line no 10
    [Serializable]
    class PlayerData_Storage
    {
        public int coin;
    }
}
