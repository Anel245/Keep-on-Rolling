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

    public float NumbersOfWaypoints;

    public GameObject Crusher;
    public float speed;
    public float rotationSpeed;
    public float fraction;

    public Rigidbody rb;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        //rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.z);
    }

   
    void Update()
    {

        if (Vector3.Distance(transform.position, target) < NumbersOfWaypoints)

        //Crusher.transform.rotation = Quaternion.LookRotation(target);
        //Vector3 direction = waypoints.position - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        //Crusher.transform.rotation = Quaternion.Slerp(Crusher.transform.rotation, Quaternion.LookRotation(target), Time.deltaTime * 10f);
        if (Vector3.Distance(transform.position, target) < waypoints.Length)
        {
                fraction += Time.deltaTime * speed;
                //transform.position = Vector3.Lerp(target);
                //yield return null;
                Quaternion toRotation = Quaternion.LookRotation(target, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            IterateWaypointIndex();
            UpdateDestination();
        }
        fraction = 0f;
  
        //else
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //}
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
