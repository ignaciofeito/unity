using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float firstSpawnDelay = 2f;
    public float intervalSpawn = 1f;

    void Start()
    {
        InvokeRepeating("Disparo", firstSpawnDelay, intervalSpawn);
    }

    private void Disparo()
    {
        Instantiate(bulletPrefab);
    }

    void Update()
    {

    }
}
