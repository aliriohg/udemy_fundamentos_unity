using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuclesExample : MonoBehaviour
{

    public int[] arregloDeEnteros;
    // Start is called before the first frame update
    void Start()
    {
        foreach(int entero in arregloDeEnteros)
        {
            print(entero);
        }
        for(int i=0; i < arregloDeEnteros.Length; i++)
        {
            print(arregloDeEnteros[i]);
            print($"Numero de repeticiones ->{i}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
