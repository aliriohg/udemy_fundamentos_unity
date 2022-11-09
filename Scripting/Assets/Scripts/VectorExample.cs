using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 nuevaPosicion;
        nuevaPosicion.x = 2;
        nuevaPosicion.y = 0.5f;
        nuevaPosicion.z = 0;
        transform.position = nuevaPosicion;

        Vector3 position2 = new Vector3(2,1,2);
        transform.position = position2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
