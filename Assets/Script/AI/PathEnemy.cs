using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEnemy : MonoBehaviour
{
    const float waypointGizmosRadius = 0.3f;

    private void OnDrawGizmos()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int j = GetNextIndex(i);
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(GetWaypoint(i), waypointGizmosRadius);
            Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
        }
    }

    private Vector3 GetWaypoint(int i)
    {
        return transform.GetChild(i).position;
    }

    private int GetNextIndex(int i)
    {
        if (i + 1 == transform.childCount) return 0;
        return i + 1;
    }
}
