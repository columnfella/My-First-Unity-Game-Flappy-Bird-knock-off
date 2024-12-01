using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GlobalUIManagerScript : MonoBehaviour
{
    public AudioSource playSound;
    public GameObject UIOverlay;

    public void loadGame()
    {
        DontDestroyOnLoad(playSound.gameObject); // Prevent destruction of the AudioSource
        playSound.Play();
        SceneManager.LoadScene("slurpy blurb");
    }
    public void openPannel(GameObject pannel)
    {
        UIOverlay.SetActive(true);
        pannel.SetActive(true);
    }

    public void closePannel(GameObject pannel)
    {
        UIOverlay.SetActive(false);
        pannel.SetActive(false);
    }
}
