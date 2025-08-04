using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D mybody2D;
    public float flapStrength;
    public Logic logic;
    public bool isAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            mybody2D.linearVelocity= Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
