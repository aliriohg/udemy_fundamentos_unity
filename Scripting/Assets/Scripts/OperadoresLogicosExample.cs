using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresLogicosExample : MonoBehaviour
{
   
    public bool logico, logicoNegado;
    public int num1, num2;
    public bool igual, distinto, mayor, menor, menorIgual, mayorIgual;
    // Start is called before the first frame update
    void Start()
    {
        logico = true;
    }

    // Update is called once per frame
    void Update()
    {
        logicoNegado = !logico;
        igual = num1 == num2;
        distinto = num1 != num2;
        menor = num1 < num2;
        menorIgual = num1 <= num2;
        mayor = num1 > num2;
        mayorIgual = num1 >= num2;

    }
}
