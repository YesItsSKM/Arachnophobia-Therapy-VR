
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SpiderAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float health;

    //Patroling
    [SerializeField] Vector3 walkPoint;
    [SerializeField] bool walkPointSet;
    public float walkPointRange;

    //States
    public float sightRange;
    public bool playerInSightRange;

    //Animator animator;

    private void Start()
    {
        InvokeRepeating("SearchWalkPoint", 0f, 5f);

        /*
        walkPointSet = false;

        playerInSightRange = false;
        playerInAttackRange = false;
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInSightRange = true;

            print("Found player");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInSightRange = false;
        }
    }

    private void Update()
    {
        if (!playerInSightRange) Patroling();
        if (playerInSightRange) ChasePlayer();
    }

    private void Patroling()
    {
        //animator.SetBool("playerInRange", false);

        //print("Patroling");

        
        //if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = player.transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }
    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        walkPointSet = true;
        print("New destination calculated!");
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
