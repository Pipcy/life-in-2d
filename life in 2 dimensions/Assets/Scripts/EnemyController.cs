using UnityEngine;
using Pathfinding; // Assuming you have imported the A* Pathfinding Project

public class EnemyController : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for the enemy to follow
    public float speed = 5f; // Speed at which the enemy moves
    public float range = 10f; // Range within which the enemy detects the player
    public float pauseTime = 2f; // Time in seconds to pause at each waypoint
    //public GameObject player;

    private int currentWaypointIndex = 0; // Index of the current waypoint
    private bool isPlayerInRange = false; // Flag to check if the player is in range
    private AIPath aiPath; // Reference to the A* pathfinding AI component


    private void Start()
    {
        aiPath = GetComponent<AIPath>(); // Get the reference to the AIPath component
        //player = GameObject.FindGameObjectWithTag("OldPlayer");
    }

    private void Update()
    {
        //Debug.Log(player.transform.position);
        // If the player is in range, activate pathfinding to chase the player
        if (isPlayerInRange)
        {
            aiPath.enabled = true;
            // Set the destination to the current position to prevent enemy movement
            //aiPath.destination = player.transform.position;
            
        }
        else
        {
            Debug.Log("Out of Range");
            aiPath.enabled = false;
            Patrol();
        }
    }

    private void Patrol()
    {
        // Check if the enemy has reached the current waypoint
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Pause at the waypoint for the specified time
            if (!IsInvoking(nameof(ChangeWaypoint)))
                Invoke(nameof(ChangeWaypoint), pauseTime);
        }

        // Move towards the current waypoint
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
    }

    private void ChangeWaypoint()
    {
        // Move to the next waypoint or start from the beginning if at the last waypoint
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player enters the enemy's range
        if (collision.CompareTag("OldPlayer"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the player exits the enemy's range
        if (collision.CompareTag("OldPlayer"))
        {
            isPlayerInRange = false;
        }
    }
}
