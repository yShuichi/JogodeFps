using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HealthBar : MonoBehaviour
{
    public float chipSpeed = 3f;
    public PlayerMovement player;
    private float lerpTimer;
    public Image frontHealthBar;
    public Image backHealthBar;
    private float Health;


    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        
        Health = player.health;
        Health = Mathf.Clamp(player.health, 0, player.maxHealth);
        UpdateHealthUI();

    }

    void UpdateHealthUI()
    {

        float fillF = frontHealthBar.fillAmount;
        float fillB = backHealthBar.fillAmount;
        float hFraction = player.health / player.maxHealth;
        if (fillB > hFraction) 
        {

            frontHealthBar.fillAmount = hFraction;
            backHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            backHealthBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);

        }

    }

    public void RestoreHealth(float healAmount)
    {

        

    }
}
