using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;
    private GameObject gameOverText;
    private AudioSource audioSource;
    public AudioClip gameStart;
    
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(gameStart, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); //Start EndGame method
        }
        else
            gameOverText.gameObject.SetActive(false); //Keep UI text game over hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); //Make game over text appear
        Time.timeScale = 0; //Freeze time
    }
}
