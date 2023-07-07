// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.AI;

// public class Navenermy : MonoBehaviour
// {
//     [SerializeField] private Transform movePositionTransform;

//     private NavMeshAgent navMeshAgent;
//     private void Awake(){
//         navMeshAgent = GetComponent<NavMeshAgent>();
//     }
//     private void Update(){
//         navMeshAgent.destination = movePositionTransform.position;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navenermy : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private float movementSpeed = 3f; // Control the movement speed

    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = movementSpeed; // Set the initial movement speed
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;

        // Update the movement speed if needed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleMovementSpeed();
        }
    }


    private void ToggleMovementSpeed()
    {
        if (navMeshAgent.speed == 0f)
        {
            navMeshAgent.speed = movementSpeed; // Enable movement by setting the speed
        }
        else
        {
            navMeshAgent.speed = 0f; // Disable movement by setting the speed to 0
        }
    }
}
