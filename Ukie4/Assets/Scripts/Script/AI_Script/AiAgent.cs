using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiAgent : MonoBehaviour
{
    public AiStateId initialState;
    //public AiAgentConfig config;

    [HideInInspector] public GameObject[] Seat;
    [HideInInspector] public GameObject[] exit;
    [HideInInspector] public GameObject[] standingPos;

    [HideInInspector] public AiStateMachine stateMachine;
    /*[HideInInspector]*/ public NavMeshAgent navMeshAgent;
    public Transform enemyCollision;



    // Start is called before the first frame update
    void Start()
    {
        
        Seat = GameObject.FindGameObjectsWithTag("Seat");
        exit = GameObject.FindGameObjectsWithTag("Exit");
        standingPos = GameObject.FindGameObjectsWithTag("StandUp");
       

        enemyCollision = transform.Find("EnemyTrigger");

        navMeshAgent = GetComponent<NavMeshAgent>();
       

        stateMachine = new AiStateMachine(this);
        stateMachine.RegisterState(new enterTrainState());
        stateMachine.RegisterState(new exitTrainState());
        stateMachine.RegisterState(new idleStandingState());
        stateMachine.RegisterState(new idleSittingState());
        stateMachine.ChangeState(initialState);
    }

    // Update is called once per frame
    public void Update()
    {
        
        Debug.Log("ai agent script " + stateMachine.currentState);
        stateMachine.Update();
        if (enemyCollision.GetComponent<enemyOnCollison>().inRange)
        {
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
               stateMachine.ChangeState(AiStateId.idleStanding);
            }
        }

    }
    
}
