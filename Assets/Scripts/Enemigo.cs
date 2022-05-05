using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variable para controlar la velocidad del Goomba
    public float movementSpeed = 4.5f;
    //variable para saber que direccion se mueve el goomba
    private int directionX = 1;
    
    //variable para almacenar el rigidbody del enemigo
    private Rigidbody2D  rigidBody;

    public bool isAlive = true;

    private GameManager gameManager;


    void Awake()
    {   
        rigidBody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isAlive)
        {
            //Añade velocidad al eje x
        rigidBody.velocity = new Vector2(directionX * movementSpeed,rigidBody.velocity.y);
        }else
        {
            rigidBody.velocity = Vector2.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.tag == "Tuberia" || hit.gameObject.layer == 6)
        {
            Debug.Log("Collision de Goomba");

            if(directionX == 1)
            {
                directionX = -1;
            }
            else
            {
                directionX = 1;
            }
        }
        else if(hit.gameObject.tag == "MuereMario")
        {
            Destroy(hit.gameObject);
            Debug.Log("Fallecimiento");
            gameManager.DeathMario();
        }
    }
}
