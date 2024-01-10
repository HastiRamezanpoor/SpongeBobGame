using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
   
   

    public float speed=6f;
    public CharacterController controller;
    public float sensX;
    public float sensY;
    private Rigidbody rb;


    public Transform orientation;


    float xRotation;
    float yRotation;
   
    void Start()
    {


        Cursor.lockState=CursorLockMode.Locked;
        Cursor.visible=false;

        rb=GetComponent<Rigidbody>();
        
    }


    void Update()
    {


     float horizontal=Input.GetAxisRaw("Horizontal");
        float vertical=Input.GetAxisRaw("Vertical");
        Vector3 direction=new Vector3(horizontal,0f,vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction*speed*Time.deltaTime);
        }



        float mouseX=Input.GetAxisRaw("Mouse X")*Time.deltaTime*sensX;
        float mouseY=Input.GetAxisRaw("Mouse Y")*Time.deltaTime*sensY;
        yRotation+=mouseX;
        xRotation+=mouseY;

        xRotation=Mathf.Clamp(xRotation,-90f,90f);
        transform.rotation=Quaternion.Euler(xRotation,yRotation,0);
        orientation.rotation=Quaternion.Euler(0,yRotation,0);


    }
}
