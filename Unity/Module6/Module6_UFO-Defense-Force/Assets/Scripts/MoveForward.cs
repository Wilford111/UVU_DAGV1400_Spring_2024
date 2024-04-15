using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 60.0f;
    private float outOfBounds = -20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
