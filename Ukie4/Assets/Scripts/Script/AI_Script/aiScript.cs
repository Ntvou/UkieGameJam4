using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiScript : MonoBehaviour
{
    [HideInInspector]public GameObject Seat;
    Animator animator;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Seat = GameObject.FindGameObjectWithTag("Seat");
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       
        

        if (agent.hasPath)
        {
          
            animator.SetBool("IsMoving", true);
        }
        else
        {
            
            animator.SetBool("IsMoving", false);
        }
    }
}
