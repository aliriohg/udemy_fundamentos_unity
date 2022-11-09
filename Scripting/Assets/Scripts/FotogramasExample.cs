using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotogramasExample : MonoBehaviour { 

    public float tiempoEntreFotogramas, fotogramasPorSegundo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoEntreFotogramas = Time.deltaTime;
        fotogramasPorSegundo = 1 / tiempoEntreFotogramas;
        transform.position += Vector3.right * Time.deltaTime;
    }
}
