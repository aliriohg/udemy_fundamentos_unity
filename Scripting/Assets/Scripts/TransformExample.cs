using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExample : MonoBehaviour
{

    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
