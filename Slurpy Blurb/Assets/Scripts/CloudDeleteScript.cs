using UnityEngine;

public class CloudDeleteScript : MonoBehaviour
{
    public float deadZone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Debug.Log("Cloud deleted");
            Destroy(gameObject);
        }

    }
}
