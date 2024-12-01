using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider audioSlider;
    public void closeGame()
    {
        Debug.Log("Game is closing...");

        // Quit the game in a build
    #if UNITY_EDITOR
        Debug.Log("Game won't quit in the editor.");
    #else
        Application.Quit();
    #endif
    }
}
