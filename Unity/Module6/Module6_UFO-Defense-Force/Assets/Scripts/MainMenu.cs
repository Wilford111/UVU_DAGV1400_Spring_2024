using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip startSound;
    public AudioClip quitSound;
    public int sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        audioSource.PlayOneShot(startSound, 1.0f);
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    public void QuitGame()
    {
        audioSource.PlayOneShot(quitSound, 1.0f);
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
