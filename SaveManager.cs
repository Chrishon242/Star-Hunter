 using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    static string NewPath;

    public static void SaveData()
    {

        string path2 = Application.persistentDataPath + "/player.fun";
        NewPath = Application.persistentDataPath + "/player.fun";

        if (File.Exists(NewPath))
        {
            Debug.Log("SAVE AN EXSITING FILE....");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path2, FileMode.Create);

            float DataScore = Highscore.FinalScore;
            float DataPlasmaToken = PlasmaToken.TotalPlasmaTokens;




            formatter.Serialize(stream, DataScore);
            formatter.Serialize(stream, DataPlasmaToken);
 
            stream.Close();
        }
        else
        {
            NewPath = Application.persistentDataPath + "/player.fun";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path2, FileMode.Create);

            float DataScore = Highscore.FinalScore;
            float DataPlasmaToken = PlasmaToken.TotalPlasmaTokens;


            formatter.Serialize(stream, DataScore);
            formatter.Serialize(stream, DataPlasmaToken);

            Debug.Log("NEW FILE SAVED....");
            stream.Close();
        }


    }


    public static PlayerData LoadData()
    {
        NewPath = Application.persistentDataPath + "/player.fun";

        if (File.Exists(NewPath))
        {
            string path = Application.persistentDataPath + "/player.fun";
            // THERE IS A FILE TO SAVE AND LOAD FROM
            if (File.Exists(path))
            {

                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                float DataScore = (float)formatter.Deserialize(stream);
                float DataPlasmaToken = (float)formatter.Deserialize(stream);

                Highscore.CurrentHighScore = DataScore;
                PlasmaToken.TotalPlasmaTokens = DataPlasmaToken;

                Debug.Log("Loading Existing File...");

                stream.Close();

                return null;
            }
            else
            {
                Debug.LogError("Saved File not Found in " + path);
                return null;
            }
        }
        else
        {
            // NO NEW FILE TO SAVE AND LOAD FROM SO CREATE ONE USING SAVEDATA()
            Debug.Log("NEw FIle");
            SaveData();
            return null;
        }

    }
}
 
