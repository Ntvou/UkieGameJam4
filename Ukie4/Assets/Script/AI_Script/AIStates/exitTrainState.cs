using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
        agent.navMeshAgent.destination = agent.exit.position;
    }

    public void Exit(AiAgent agent)
    {
        
    }

    public AiStateId GetId()
    {
        return AiStateId.exitTrain;
    }

    public void Update(AiAgent agent)
    {
       if(agent.navMeshAgent.destination == agent.exit.position)
        {
            agent.stateMachine.ChangeState(AiStateId.idleStanding);
        }
       
    }

   
}
