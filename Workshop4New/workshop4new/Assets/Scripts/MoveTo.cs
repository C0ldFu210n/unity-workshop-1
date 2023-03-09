using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public GameObject target;

    void FixedUpdate() {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
    }
}
