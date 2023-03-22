using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
 
    public float sensX;
    public float sensY;

    private ControladorJogo gameController;
    
    public Transform orientation;
    
    public float xRotation;
    public float yRotation;

    
    void Start()
    {

        gameController = GameObject.Find("GameController").GetComponent<ControladorJogo>();

    }


    void Update()
    {

        if (gameController.JogoON) {

            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;
            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90, 90);

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);


        }
        
    }
}
