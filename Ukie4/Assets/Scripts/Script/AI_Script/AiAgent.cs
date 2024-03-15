using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiAgent : MonoBehaviour
{
    public AiStateId initialState;
    //public AiAgentConfig config;

    /*[HideInInspector]*/ public Transform Seat;
    [HideInInspector] public Transform exit;
    [HideInInspector] public AiStateMachine stateMachine;
    /*[HideInInspector]*/ public NavMeshAgent navMeshAgent;
    public Transform enemyCollision;



    // Start is called before the first frame update
    void Start()
    {
        Seat = GameObject.FindGameObjectWithTag("Seat").transform;
        exit = GameObject.FindGameObjectWithTag("Exit").transform;

        enemyCollision = transform.Find("EnemyTrigger");

        navMeshAgent = GetComponent<NavMeshAgent>();
       

        stateMachine = new AiStateMachine(this);
        stateMachine.RegisterState(new enterTrainState());
        stateMachine.RegisterState(new exitTrainState());
        stateMachine.RegisterState(new idleStandingState());
        stateMachine.ChangeState(initialState);
    }

    // Update is called once per frame
    public void Update()
    {
        
        Debug.Log("ai agent script " + stateMachine.currentState);
        stateMachine.Update();


    }
    
}
