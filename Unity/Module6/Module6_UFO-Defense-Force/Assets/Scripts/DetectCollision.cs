using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //store reference to score manager
    public AudioClip explosion;
    private AudioSource audioSource;

    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManager gameobject and reference ScoreManager script component
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = true;
    }

    void OnTriggerEnter(Collider other) //Once the trigger has been entered, record collision in the argument variable "other"
    {
        if(other.gameObject.CompareTag("Laser"))
        {
            audioSource.PlayOneShot(explosion, 1.0f);
            scoreManager.IncreaseScore(scoreToGive); //Increase the score
            StartCoroutine(DestroyObjectAfterAudio());
            gameObject.transform.position = new Vector3(0, -20, 10);
            Destroy(other.gameObject); //Destroy the game object it hits.
        }
    }
    IEnumerator DestroyObjectAfterAudio()
    {
        yield return new WaitForSeconds(explosion.length);

        Destroy(gameObject);
    }
}
