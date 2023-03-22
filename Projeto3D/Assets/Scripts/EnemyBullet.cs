using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemyHitEffect;
    void Start()
    {
        
        Destroy(gameObject, 10);

    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Player") {

            collision.gameObject.GetComponent<PlayerMovement>().TakeDamage(20f);
            GameObject tempEffect = Instantiate(enemyHitEffect, gameObject.transform.position, Quaternion.identity);
            Destroy(tempEffect, 3);
            Destroy(gameObject);

        }

    }

}
