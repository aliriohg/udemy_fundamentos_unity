using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionalCiclosExamples : MonoBehaviour
{
    public bool activado;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activado)
        {
            meshRenderer.material.color = Color.green;
        }
        else
        {
            meshRenderer.material.color = Color.blue;

        }
    }
}
