using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArregloDeDatos : MonoBehaviour
{

    public int[] arregloDeEnteros;
    // Start is called before the first frame update
    void Start()
    {
        arregloDeEnteros[0] = 100;
        print(arregloDeEnteros[2]); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
