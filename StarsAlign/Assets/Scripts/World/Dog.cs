// using UnityEngine;

// public class Dog : MonoBehaviour
// {
//     public Transform player;
//     public float detectionDistance = 5f;
//     public float runSpeed = 5f;
//     public float returnSpeed = 2f;

//     private Rigidbody2D rb2d;
//     private Vector2 originalPosition;
//     private bool isRunningAway = false;

//     void Start()
//     {
//         rb2d = GetComponent<Rigidbody2D>();
//         originalPosition = rb2d.position;
//     }

// void Update()
// {
//     if (player == null)
//         player = GameObject.FindGameObjectWithTag("Player").transform;

//     if (player != null)
//     {
//         Vector2 distanceToPlayer = rb2d.position - (Vector2)player.position;

//         // If the player is within the detection range, run away from the player
//         if (distanceToPlayer.magnitude < detectionDistance)
//         {
//             Vector2 moveDirection = distanceToPlayer.normalized;
//             rb2d.MovePosition(rb2d.position + moveDirection * runSpeed * Time.deltaTime);
//             isRunningAway = true;

//             // Ignore collisions with objects tagged as "Tree"
//             IgnoreTreeCollisions(true);
//         }
//         else if (isRunningAway)
//         {
//             Vector2 moveDirection = (originalPosition - rb2d.position).normalized;
//             rb2d.MovePosition(rb2d.position + moveDirection * returnSpeed * Time.deltaTime);

//             if (Vector2.Distance(rb2d.position, originalPosition) < 0.2f) // Adjust threshold as needed
//             {
//                 rb2d.position = originalPosition; // Ensure exact position on arrival
//                 isRunningAway = false;
//                 IgnoreTreeCollisions(false);
//             }
//         }
//     }
// }

// void IgnoreTreeCollisions(bool ignore)
// {
//     GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");
//     foreach (GameObject tree in trees)
//     {
//         Collider2D treeCollider = tree.GetComponent<Collider2D>();
//         if (treeCollider != null)
//         {
//             Physics2D.IgnoreCollision(GetComponent<Collider2D>(), treeCollider, ignore);
//         }
//     }
// }
// }
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public float flySpeed = 5f; // Speed at which the butterfly moves when fleeing
    public float detectionRange = 3f; // Distance to detect the player
    public float roamRange = 5f; // Range within which the butterfly roams
    public float changeDirectionTime = 2f; // Time interval to change direction while roaming

    private Transform player; // Reference to the player's transform
    private Vector2 randomDirection; // Random direction for roaming
    private float roamTimer; // Timer to change direction while roaming

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player object
        roamTimer = changeDirectionTime;
        SetRandomDirection();
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            // Check if the player is within the detection range
            if (distanceToPlayer < detectionRange)
            {
                // Calculate the direction away from the player
                Vector2 direction = (transform.position - player.position).normalized;

                // Move the butterfly away from the player
                transform.Translate(direction * flySpeed * Time.deltaTime);
            }
            else
            {
                RoamAround();
            }
        }
    }

    void RoamAround()
    {
        roamTimer -= Time.deltaTime;

        if (roamTimer <= 0f)
        {
            SetRandomDirection();
            roamTimer = changeDirectionTime;
        }

        // Move the butterfly in a random direction while roaming
        transform.Translate(randomDirection * flySpeed * Time.deltaTime);
    }

    void SetRandomDirection()
    {
        randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}











