using UnityEngine;

public class Dog : MonoBehaviour
{
    public Transform player;
    public float detectionDistance = 5f;
    public float runSpeed = 5f;
    public float returnSpeed = 2f;

    private Rigidbody2D rb2d;
    private Vector2 originalPosition;
    private bool isRunningAway = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        originalPosition = rb2d.position;
    }

    void Update()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player != null)
        {
            Vector2 distanceToPlayer = rb2d.position - (Vector2)player.position;

            // If the player is within the detection range, run away from the player
            if (distanceToPlayer.magnitude < detectionDistance)
            {
                Vector2 moveDirection = distanceToPlayer.normalized;
                rb2d.MovePosition(rb2d.position + moveDirection * runSpeed * Time.deltaTime);
                isRunningAway = true;

                // Ignore collisions with objects tagged as "Tree"
                GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");
                foreach (GameObject tree in trees)
                {
                    Collider2D treeCollider = tree.GetComponent<Collider2D>();
                    if (treeCollider != null)
                    {
                        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), treeCollider, true);
                    }
                }
            }
            else if (isRunningAway)
            {
                Vector2 moveDirection = (originalPosition - rb2d.position).normalized;
                rb2d.MovePosition(rb2d.position + moveDirection * returnSpeed * Time.deltaTime);

                if (Vector2.Distance(rb2d.position, originalPosition) < 0.1f)
                {
                    isRunningAway = false;

                    // Restore collision detection with objects tagged as "Tree"
                    GameObject[] trees = GameObject.FindObjectsOfType<GameObject>();
                    foreach (GameObject tree in trees)
                    {
                        Collider2D treeCollider = tree.GetComponent<Collider2D>();
                        if (treeCollider != null && tree.tag == "Tree")
                        {
                            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), treeCollider, false);
                        }
                    }
                }
            }
        }
    }
}










