using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleStandingState : AiState
{
    public void Enter(AiAgent agent)
    {
        int randNum = Random.Range(0, agent.standingPos.Length);
        agent.navMeshAgent.destination = agent.standingPos[randNum].transform.position;
        Debug.Log(randNum);
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
