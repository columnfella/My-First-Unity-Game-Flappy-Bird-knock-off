using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float upperBound = 10;
    public float lowerBound = -10;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe ()
    {
        Instantiate(pipe, new Vector2(transform.position.x, Random.Range(lowerBound, upperBound)), transform.rotation);
    }
}
