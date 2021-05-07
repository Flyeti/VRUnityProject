using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT.");
        Application.Quit();
    }

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }
}
