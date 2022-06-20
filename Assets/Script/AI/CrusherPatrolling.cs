using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrusherPatrolling : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
<<<<<<< Updated upstream
    public float NumbersOfWaypoints;
=======
    public GameObject Crusher;
    public float speed;
    public float rotationSpeed;
>>>>>>> Stashed changes

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

   
    void Update()
    {
<<<<<<< Updated upstream
        if (Vector3.Distance(transform.position, target) < NumbersOfWaypoints)
=======
        //Crusher.transform.rotation = Quaternion.LookRotation(target);
        //Vector3 direction = waypoints.position - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        //Crusher.transform.rotation = Quaternion.Slerp(Crusher.transform.rotation, Quaternion.LookRotation(target), Time.deltaTime * 10f);
        if (Vector3.Distance(transform.position, target) < waypoints.Length)
>>>>>>> Stashed changes
        {
            Quaternion toRotation = Quaternion.LookRotation(target, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        //transform.LookAt(target);
        //transform.Rotate(Vector3.right * speed * Time.deltaTime);
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
