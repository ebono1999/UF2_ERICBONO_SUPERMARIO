using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 newPosition = new Vector3(50, 5, 0);

    public float movementSpeed = 5;

    private float inputHorizontal;

    public bool jump = false;

    public SpriteRenderer render;


    // Start is called before the first frame update
    void Start()
    {   //Teletransporta al personaje a una nueva posicion que es la que sale en la variable new position
        //transform.position = newPosition;

        render= GetComponent <SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3 (1,0,0) * movementSpeed * Time.deltaTime;
        transform.position += new Vector3 (inputHorizontal,0,0) * movementSpeed * Time.deltaTime;

        if(jump == true)
        {
            Debug.Log("Estoy saltando");

        }
        else
        {
            Debug.Log("Estoy en el suelo");
            

        }

        if(inputHorizontal < 0)
        {
            render.flipX = true;
        }
        else if(inputHorizontal > 0)
        {
            render.flipX = false;
        }


    }
}
