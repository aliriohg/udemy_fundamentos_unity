using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefabs;
    public float spwanTimer = 2f;
    public static SpawnManager Instance
    {
        get; private set;
    }

    private void Awake()
    {
        Instance = this;
    }

    // Iniciar generacion
    public void StartSpawn()
    {
        InvokeRepeating("SpawnEnemy",0f,spwanTimer);
    }

    // Generar Enemigo
    private void SpawnEnemy()
    {
     GameObject enemy = Instantiate(enemyPrefabs, transform.position, Quaternion.identity);
    }
    // Parar la generacion
     public void StopSpawn()
    {
        CancelInvoke("SpawnEnemy");
    }

}
