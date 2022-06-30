using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 

{
    
    public static void SavePlayer(Player player)
    {
        BinaryFormatter binary = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.meujogo"; // talto faz o nome, player é o nome do arquivo
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        binary.Serialize(stream, data);
        stream.Close();

        Debug.Log("Jogo salvo");
    }
    
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.meujogo";

        if (File.Exists(path)) // se existir
        {
            // carrega os dados

            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = binary.Deserialize(stream) as PlayerData;
            Debug.Log("Jogo carregado com sucesso!");
            return data;

            
        }
        else
        {
            //debug erro ou não faz nada
            Debug.Log("Arquivo não existe" + path);
            return null;
        }
    
    }


}
