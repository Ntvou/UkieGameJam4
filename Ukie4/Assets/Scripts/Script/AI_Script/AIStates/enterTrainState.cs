using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
        int randNum = Random.Range(0, agent.Seat.Length);
        agent.navMeshAgent.destination = agent.Seat[randNum].transform.position;
        Debug.Log(randNum);
    }

    public void Exit(AiAgent agent)
    {
        
    }

    public AiStateId GetId()
    {
        return AiStateId.enterTrain;
    }

    public void Update(AiAgent agent)
    {
        if (!agent.navMeshAgent.hasPath)
        {
            agent.stateMachine.ChangeState(AiStateId.idleSitting);
        }

    }
}
