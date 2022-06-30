using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Vector2 lastCheckpoint;

    void Start()
    {
        if (instance == null) // se o instance não existir
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else  // se for nulo
        {
            Destroy(gameObject);
        }
    }

}
