using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScrip : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght, bounceStrenght;
    private float counter = 0;
    public LogicScript logic;
    public PipeMoveScript pipeMove;
    private bool birdIsAlive = true;
    public AudioSource birdDeath;
    public bool soundIsPlayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pipeMove = GameObject.FindGameObjectWithTag("Pipe Move").GetComponent<PipeMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (birdIsAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.linearVelocity = Vector2.up * flapStrenght;
            }
        }
        else
        {
            // Move the bird to the left at the same speed as the pipes
            transform.position += Vector3.left * pipeMove.moveSpeed * Time.deltaTime;

            if (!soundIsPlayed)
            {
                birdDeath.Play();
                soundIsPlayed = true;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        counter += 5f / (100 * bounceStrenght);

        switch (collision.gameObject.layer)
        {
            case 6:
            case 7:
                logic.gameOver();
                birdIsAlive = false;
                myRigidbody.linearVelocity = Vector2.up * (1f / counter);
                break;
        }
    }

}