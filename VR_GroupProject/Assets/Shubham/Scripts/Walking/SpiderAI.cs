using UnityEngine;
using UnityEngine.AI;

public class SpiderAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //public float health;

    //Patroling
    Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //States
    public float sightRange, foundRange;
    bool playerInSightRange;
    bool playerFound;

    public Animator animator;

    bool playerSpotted;

    private void Start()
    {
        InvokeRepeating("SearchWalkPoint", 5f, 10f);
    }

    private void Update()
    {
        playerFound = Physics.CheckSphere(transform.position, foundRange, whatIsPlayer);
        if (playerFound)
        {
            animator.SetBool("isWalking", false);
        }

        else
        {
            animator.SetBool("isWalking", true);

            playerSpotted = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

            if (playerSpotted)
            {
                playerInSightRange = true;
            }
            else
            {
                playerInSightRange = false;
            }

            if (!playerInSightRange) Patroling();
            if (playerInSightRange) ChasePlayer();
        }
    }

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        walkPointSet = true;
    }

    private void Patroling()
    {
        animator.Play("walk");

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = player.transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }
    

    private void ChasePlayer()
    {
        animator.Play("walk");

        agent.SetDestination(player.position);
    }
}
