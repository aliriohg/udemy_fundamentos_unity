using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaScripting : MonoBehaviour
{

    public Color color;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
