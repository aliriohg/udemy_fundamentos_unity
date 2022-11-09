using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{

    public Transform[] bloques;
    public Vector3[] direcciones;
    public bool movimientoLateral;

    // Start is called before the first frame update
    void Start()
    {
        direcciones = new Vector3[]
        {
            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoLateral)
        {
            for (int i = 0; i < bloques.Length; i++)
            {
                bloques[i].position += (i + 1) * direcciones[i] * Time.deltaTime;
                if (bloques[i].position.x < -4)
                {
                    direcciones[i] = Vector3.right;
                }
                else if (bloques[i].position.x > 4)
                {
                    direcciones[i] = Vector3.left;

                }
            }
        }
        else
        {
            Vector3 aux;
            for (int i = 0; i <= bloques.Length-1; i++)
            {
                if (i >= bloques.Length / 2)
                {
                    print($"break becouse i {i} and length {bloques.Length}");
                    break;
                }
                aux = bloques[i].position;
                bloques[i].position =bloques[bloques.Length-i-1].position;
                bloques[bloques.Length - i-1].position = aux;


            }
        }
       
    }
}
