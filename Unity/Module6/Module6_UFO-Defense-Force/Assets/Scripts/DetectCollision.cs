using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //store reference to score manager

    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManager gameobject and reference ScoreManager script component

    }

    void OnTriggerEnter(Collider other) //Once the trigger has been entered, record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); //Increase the score
        Destroy(gameObject); //Destroy this game object
        Destroy(other.gameObject); //Destroy the game object it hits
    }
}
