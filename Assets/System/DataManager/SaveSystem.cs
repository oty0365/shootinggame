using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class SaveSystem
{
    /*public static void SavePalyer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData();
        formatter.Serialize(stream,data);
        stream.Close();
    }*/

    public static void SaveStage(StageManager stageManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/stage.fun";
        StageData data = new StageData(stageManager);

        FileStream stream;
        if (File.Exists(path))
        {
            using (stream = new FileStream(path, FileMode.Open))
            {
                if (formatter.Deserialize(stream) is StageData saved && saved.stage >= data.stage) return;
            }
        }

        using (stream = new FileStream(path, FileMode.Create))
        {
            formatter.Serialize(stream, data);
        }
    }

    /*public static void LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            
        }
        else
        {
            Debug.LogError("File Not Found");
        }
    }*/
    public static StageData LoadStage()
    {
        string path = Application.persistentDataPath + "/stage.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);
            StageData data = formatter.Deserialize(stream) as StageData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File Not Found");
            return null;
        }
    }

    public static StageData DeleteStage()
    {
        string path = Application.persistentDataPath + "/stage.fun";
        if (File.Exists(path))
        {
            File.Delete(path);
            return null;
        }
        else
        {
            Debug.LogError("File Not Found");
            return null;
        }
    }
}
