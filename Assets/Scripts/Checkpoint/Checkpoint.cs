using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameController GC;

     void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GC").GetComponent<GameController>();    
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GC.lastCheckpoint = transform.position;
        }
    }
}
