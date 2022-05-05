using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables para velocidad-fuerza de salto
    public float speed = 5f; 
    public float jumpForce = 10f;
    //variable para saber siestamos en el suelo
    public bool isGrounded;
    //variable para almacenar el movimiento
    float dirX; 

    //variables de componentes
    public SpriteRenderer renderer;
    public Animator _animator;
    Rigidbody2D _rigidbody; 

    void Awake()
    {

      //asignamos los componentes de las variables
      _animator = GetComponent<Animator>(); 
      _rigidbody = GetComponent<Rigidbody2D>();

    }

     void Update()
    {
      dirX = Input.GetAxisRaw("Horizontal");  

      Debug.Log(dirX);

      

       /*transform.position += new Vector3(dirX, 0, 0) * speed * Time.deltaTime;*/

      if(dirX == -1)
      {
         //renderer.flipX = true; 
         _animator.SetBool("andar", true);
         transform.rotation = Quaternion.Euler(0,180,0);
      }
        else if(dirX == 1)
     {
        //renderer.flipX = false;
        _animator.SetBool("andar", true);
        transform.rotation = Quaternion.Euler(0,0,0);
    }
      else 
      {
        _animator.SetBool("andar", false);
      }

      if(Input.GetButtonDown("Jump") && isGrounded)
      {
        _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
        _animator.SetBool("saltar", true);
      }

      

      /*if (Input.GetButtonDown("Fire1") && gameManager.shootPowerUp == true)
      {
        Instantiate(bulletPref, bulletSpawn.position, bulletSpawn.rotation);
      }*/
    }

     void FixedUpdate()
  {
  _rigidbody.velocity = new Vector2(dirX * speed, _rigidbody.velocity .y);

  }

}