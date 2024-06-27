using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Datamanager : MonoBehaviour
{
    public string path;
    public string file = "player.txt";
    public PlayerStatus data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        data = new PlayerStatus();
        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data);

    }
    public void Save()
    {
        string json = JsonUtility.ToJson(PlayerStatus.playerhp);
        WriteToFile(file, json);
    }

    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.Log("FileNotFound");
        }

        return "";
    }
}
