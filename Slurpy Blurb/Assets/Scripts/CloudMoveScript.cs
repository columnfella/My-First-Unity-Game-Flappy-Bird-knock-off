using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeedUpperBound = 3;
    public float moveSpeedLowerBound = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Random.Range(moveSpeedLowerBound, moveSpeedUpperBound) * Time.deltaTime;
    }
}
