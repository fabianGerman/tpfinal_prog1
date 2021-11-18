using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
     //Propiedades
    public float velx = 10;
    public float vely = 10;
    public float velz = 10;
    //public Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        //animatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Input.GetAxis("Horizontal") * velx * Time.deltaTime,0,0);
        //transform.Translate(0,Input.GetAxis("Vertical") * vely * Time.deltaTime,0);
        transform.Translate(0,0,Input.GetAxis("Vertical") * velz * Time.deltaTime); 
/*
        if (Input.GetKeyDown(KeyCode.W)){
            animatorController.SetBool("walking", true);
        }else if(Input.GetKeyUp(KeyCode.W)){
            animatorController.SetBool("walking", false);
        }*/
    }
}
