using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
       
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
        agent.navMeshAgent.destination = agent.Seat.position;
       
    }
}
