using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Direction heading;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 5000;
        heading = DirectionUtilities.GetRandomDirection();
    }

    void Update()
    {
        // Convert the current heading to a Vector2
        Vector2 direction = heading.ToVector2();
        
        // Apply the movement using the rigidbody
        rb.linearVelocity = direction * moveSpeed;

        // Optionally, you can randomly change direction periodically
        if (Random.value < 0.01f) // 1% chance each frame to change direction
        {
            heading = DirectionUtilities.GetRandomDirection();
        }
    }
}
