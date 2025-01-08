using UnityEngine;

public class controler : MonoBehaviour
{
    private Rigidbody2D rb;
    private int frameCount = 30;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 5000;
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-5, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(5, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -5);
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 5);
        }       


        frameCount++;

        if (frameCount >= 30)
        {
            GameEvents.OnSpeedChanged.Invoke(rb.angularVelocity);
            frameCount = 0; // Reset the frame counter
        }
    }
}
