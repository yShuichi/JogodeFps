using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float health;
    public GameObject Jogador;


    void Start()
    {
        health = 100;
        Jogador = GameObject.FindGameObjectWithTag("Player");
       
    }

    void Update()
    {
        
        
    }

    public void TakeDamage(float damage) {

        this.health -= damage;

        if (this.health <= 0) {


            Destroy(gameObject);



        }
    }

    void OnCollisionEnter(Collision collision) {


        if (collision.gameObject.tag == "Bullet") {

            Debug.Log("Colidiu com a bala");
            TakeDamage(collision.gameObject.GetComponent<CustomBullet>().damage);
            Destroy(collision.gameObject);

        }

    }

}
