using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
        agent.navMeshAgent.destination = agent.Seat.position;
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
            agent.stateMachine.ChangeState(AiStateId.idleStanding);
        }

    }
}
