using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class UnityBinarySaver
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.ubs";
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, player);
        stream.Close();
    }

    public static Player LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.ubs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Player player = formatter.Deserialize(stream) as Player;
            stream.Close();

            return player;
        }
        else
        {
            Debug.LogError("File not found at " + path);
            return null;
        }
    }
}
