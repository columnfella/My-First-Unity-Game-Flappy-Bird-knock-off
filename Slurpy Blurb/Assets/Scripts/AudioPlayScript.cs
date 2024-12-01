using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource

    // Method to play the sound
    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }
}