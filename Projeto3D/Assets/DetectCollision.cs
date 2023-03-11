using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public float health;
    public float maxHealth;

    void Start()
    {
        
        health = maxHealth;

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {

        if (collision.gameObject.tag == "EnemyBullet") 
        {

            TakeDamage(40);
            Destroy(collision.gameObject);
            

        }

    }

    private void TakeDamage(float damage) 
    {

        this.health -= damage;

        if (this.health <= 0) 
        {

            Destroy(gameObject.transform.parent.gameObject);

        }

    }

}
