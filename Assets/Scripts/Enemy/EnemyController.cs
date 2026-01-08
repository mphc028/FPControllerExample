using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        player = PlayerController.Instance.transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(new Vector3(player.position.x, transform.position.y, player.position.z));
        }
    }
}