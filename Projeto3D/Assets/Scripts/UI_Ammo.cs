using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Ammo : MonoBehaviour
{

    public TMP_Text texto;
    private ProjectileGun minhaArma;

    void Start()
    {
        
        minhaArma = GameObject.FindGameObjectWithTag("Gun").GetComponent<ProjectileGun>();

    }


    void Update()
    {

        texto.text = "Arma: " + minhaArma.bulletsLeft.ToString() + " / " + minhaArma.magazineSize.ToString();
        
    }
}
