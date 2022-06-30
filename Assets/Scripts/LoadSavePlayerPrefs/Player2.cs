using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int level = 3;
    public int health = 100;
    public Vector3 Pos;


    public void Save()
    {
        PlayerPrefsSystem.SavePlayer(this);
    }

    public void Load()
    {
        PlayerPrefsSystem.LoadPlayer(this);
        
        transform.position = Pos;
    }
}
