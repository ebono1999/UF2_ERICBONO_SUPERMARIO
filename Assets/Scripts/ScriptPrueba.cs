using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPrueba : MonoBehaviour
{
    public int vidasPersonajes = 5;
    public int vidasPersonajes2 = 2;
    public float numeroDecimal = 3.5f;
    public string letrasTexto = "mario";
    public bool interruptor = true;
    // Start is called before the first frame update
    void Start()
    {
        vidasPersonajes = 1;
        numeroDecimal = 3.33f;
        letrasTexto = "MarioCanario";

        int suma = vidasPersonajes + vidasPersonajes2;
        Debug.Log(suma);
        string sumaTextos = letrasTexto + "machango";
        Debug.Log(sumaTextos);

        Debug.Log("Mario");
        Debug.Log(vidasPersonajes);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
