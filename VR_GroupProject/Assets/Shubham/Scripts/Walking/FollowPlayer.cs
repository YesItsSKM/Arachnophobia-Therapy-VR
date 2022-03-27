using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent spider;

    //public float chaseRange, stopRange;

    // Update is called once per frame
    void Update()
    {
        spider.SetDestination(target.position);
    }
}
