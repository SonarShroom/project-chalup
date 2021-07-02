using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Entity : MonoBehaviour
{

    //Stats
    public float ChaseRange;
    public float AttackRange;
    public float RoarRange;
    public float Speed;


    //AI and references
    [HideInInspector]
    public NavMeshAgent agent;
    [HideInInspector]
    public Transform playercharacter;
     public bool isChasing = true;
    public Transform hideout;


    void Start()
    {
        starter();
        agent = GetComponent<NavMeshAgent>();
        playercharacter = EventManager.instance.PlayerCharacter.transform;
    }


    private void Update()
    {
        if (isChasing)
        {
            if (PlayerDistance() <= AttackRange)
            {
                Attack();
            }

            else if (PlayerDistance() <= ChaseRange)
            {
                Chasing();
            }
            else
            {
                Idle();
            }
            if (PlayerDistance() <= RoarRange)
            {
                Roar();
            }
            else
            {
                StopRoar();
            }
        }
        else
        {
            agent.SetDestination(hideout.position);
        }
    }


    public virtual void starter()
    {

    }
    public virtual void Idle()
    {

    }
    public virtual void Chasing()
    {

    }
    public virtual void Attack()
    {

    }
    public virtual void Roar()
    {

    }
    public virtual void StopRoar()
    {

    }
    public float PlayerDistance()
    {

        float dist;

        dist = Vector3.Distance(transform.position , playercharacter.transform.position);


        return dist;
    }

    void chasemode()
    {
        isChasing = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Arrow")
        {
            isChasing = false;
            Invoke("chasemode", 10f);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, ChaseRange);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, RoarRange);
    }
}
