using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [Header("Movimentar Player")]
    public float Velocidade;


    // Checkpoint
    private GameController GC;

     void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GC").GetComponent<GameController>();
        transform.position = GC.lastCheckpoint; // toda vez que eu carregar o jogo o player vai receber a posição do último checkpoint
    }

    void Update()
    {
       
        //// movimentando o player  maneira 1
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(1,0,0) * Velocidade * Time.deltaTime);

        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-new Vector3(1,0,0) * Velocidade * Time.deltaTime);
        //}

        // movimentar maneira 2

        float direction = Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + direction, transform.position.y);



        // Aperte Espaço para reiniciar (apenas para testes)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}


