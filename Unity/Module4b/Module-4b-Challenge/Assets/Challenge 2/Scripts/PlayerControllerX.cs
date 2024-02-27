using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnDelay = 0.4f;
    public float timer = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // increase timer by deltaTime
        if(timer < 2){
            timer += Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer >= spawnDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Reset timer to 0
            timer = 0;
        }
    }
}
