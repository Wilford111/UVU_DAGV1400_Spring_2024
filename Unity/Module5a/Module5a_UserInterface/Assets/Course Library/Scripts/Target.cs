using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody objectRb;
    private float forceMax = 15;
    private float forceMin = 12;
    private float torqueRange = 10;
    private float xRange = 4;
    private float ySpawn = -2;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();

        objectRb.AddForce(RandomForce(), ForceMode.Impulse);
        objectRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(forceMin, forceMax);
    }

    float RandomTorque()
    {
        return Random.Range(torqueRange, -torqueRange);
    }

    Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(xRange, -xRange), ySpawn);
    }
}
