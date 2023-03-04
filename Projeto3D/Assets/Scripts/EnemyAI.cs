using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float health;
    public Animator animController;


    void Start()
    {
        health = 100;
        animController = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage) {

        this.health -= damage;

        if (this.health <= 0) {

            animController.SetBool("Idle", false);
            animController.SetBool("Dead", true);

            Destroy(transform.parent.gameObject, 3);



        }


    }
}
