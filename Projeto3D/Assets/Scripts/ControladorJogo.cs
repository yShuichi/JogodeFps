using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogo : MonoBehaviour
{
    
    public bool JogoON;
    public GameObject TelaInicial;

    void Start()
    {
        JogoON = false;
        

    }

    
    void Update()
    {
        
    }


    public void Iniciar()
    {

        JogoON = true;
        TelaInicial.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    
}
