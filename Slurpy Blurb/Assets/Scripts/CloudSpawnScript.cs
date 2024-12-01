using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float lowerBound;
    public float upperBound;
    public float spawnRateUpperBound;
    public float spawnRateLowerBound;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Random.Range(spawnRateLowerBound, spawnRateUpperBound)) {
            timer += Time.deltaTime;
        } else {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowerBound, upperBound), 1), transform.rotation);
    }
}
