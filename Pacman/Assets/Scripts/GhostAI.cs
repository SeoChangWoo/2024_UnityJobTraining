using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GhostAI : MonoBehaviour
{
    public Transform[] waypoints;
    public NavMeshAgent ai;
    public int currentWaypointIndex;

    void Start()
    {
        currentWaypointIndex = 0;
    }

    void Update()
    {
        if(!ai.pathPending && ai.remainingDistance < 0.5f)
        {
            MoveToNextWaypoint();
        }
    }

    void MoveToNextWaypoint()
    {
        ai.destination = waypoints[currentWaypointIndex].position;

        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pacman")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
