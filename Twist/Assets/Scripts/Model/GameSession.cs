using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public static class GameSession
    {

        public static void SaveSession(string currentLevel, bool muteMusicRecord)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/gameSession.dat";
            FileStream stream = new FileStream(path, FileMode.Create);

            PlayerData data = new PlayerData(currentLevel, muteMusicRecord);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerData LoadDataSession()
        {
            string path = Application.persistentDataPath + "/gameSession.dat";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();

                return data;
            }
            else
            {
                Debug.LogError("Save file not found in " +  path);
                return null;
            }
        }
    }
}
