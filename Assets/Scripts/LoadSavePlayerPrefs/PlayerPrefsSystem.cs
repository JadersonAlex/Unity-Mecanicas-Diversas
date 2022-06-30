using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSystem : MonoBehaviour
{
    //salvando o jogo
    public static void SavePlayer(Player2 player)
    {
        PlayerPrefs.SetInt("level", player.level);
        PlayerPrefs.SetInt("health", player.health);
        PlayerPrefs.SetFloat("positionX", player.Pos.x);
        PlayerPrefs.SetFloat("positionY", player.Pos.y);
        PlayerPrefs.SetFloat("positionZ", player.Pos.z);
        Debug.Log("Jogo salvo");
    }

    //carregando
    public static Player2 LoadPlayer(Player2 player)
    {
        if (PlayerPrefs.HasKey("level")) // se existir eu sei que salvei
        {
            // já existe algo salvo, ou seja, carregar o jogo
            player.level = PlayerPrefs.GetInt("level");
            player.health = PlayerPrefs.GetInt("health");
            player.Pos.x = PlayerPrefs.GetFloat("positionX");
            player.Pos.y = PlayerPrefs.GetFloat("positionY");
            player.Pos.z = PlayerPrefs.GetFloat("positionZ");

            Debug.Log("jogo carregado");
            return player;
        }
        else
        {
            // não existe jogo salvo
            Debug.Log("sem dados salvos");
            return null;
        }
    }
}
