using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour {

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        agent.SetDestination(player.transform.position);
    }
}
