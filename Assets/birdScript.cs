using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D mybody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mybody2D.linearVelocity= Vector2.up * 10;
        }
        
    }
}
