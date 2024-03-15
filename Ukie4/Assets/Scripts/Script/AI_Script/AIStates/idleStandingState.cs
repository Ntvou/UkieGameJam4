using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleStandingState : AiState
{
    public void Enter(AiAgent agent)
    {
       
        agent.navMeshAgent.destination = agent.standingPos.position;
    }

    public void Exit(AiAgent agent)
    {
        
    }

    public AiStateId GetId()
    {
        return AiStateId.idleStanding;
    }

    public void Update(AiAgent agent)
    {
        
    }

   
}
