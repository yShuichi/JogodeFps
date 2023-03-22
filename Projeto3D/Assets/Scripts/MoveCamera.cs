using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPos;
    private ControladorJogo gameController;


    void Start() {


        gameController = GameObject.Find("GameController").GetComponent<ControladorJogo>();

    }

    void Update()
    {
        if (gameController.JogoON){

            transform.position =  cameraPos.position;

        }else {




        }

    }
}
