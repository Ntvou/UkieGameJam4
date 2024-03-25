using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
        int randNum = Random.Range(0, agent.exit.Length);
        agent.navMeshAgent.destination = agent.exit[randNum].transform.position;
        Debug.Log(randNum);
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
       if(!agent.navMeshAgent.hasPath)
        {
           
            agent.stateMachine.ChangeState(AiStateId.idleSitting);
        }
       
    }

   
}
