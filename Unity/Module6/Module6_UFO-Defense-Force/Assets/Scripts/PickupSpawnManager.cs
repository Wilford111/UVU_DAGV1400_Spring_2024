using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{
    public GameObject pickup;
    private float xBounds = 23.0f;
    private float zBounds = 25.0f;
    public float startDelay = 5.0f;
    public float spawnTimer = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPickup()
    {
        float randomX = Random.Range(-xBounds, xBounds);

        Vector3 spawnPos = new Vector3(randomX, 0.5f, zBounds);

        Instantiate(pickup, spawnPos, pickup.gameObject.transform.rotation);
    }
}
