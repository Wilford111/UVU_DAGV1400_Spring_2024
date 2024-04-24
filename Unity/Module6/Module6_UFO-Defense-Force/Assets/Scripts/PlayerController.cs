using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip pickupSound;
    private float horizontalInput;
    public float speed = 35;
    private float score = 0;
    private float xRange = 25;
    public Transform blaster;
    public GameObject laserBolt;
    public GameObject pickup;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager script on GameManager object
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from keyboard/analog stick
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player within bounds of left side wall
        if(transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Keep player within bounds of right side wall
        if(transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //If space bar is pressed:
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            //Create laserBolt at the blaster's position and maintaining the object's rotation
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }

    //Delete any object with a trigger that hits the player
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(pickupSound, 1.0f);
            score += 1;
            Debug.Log("Pickups: " + score);
        }
    }
}
