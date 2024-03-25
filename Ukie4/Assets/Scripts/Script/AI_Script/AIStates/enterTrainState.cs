using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class enterTrainState : AiState
{
    public void Enter(AiAgent agent)
    {
        int randNum = Random.Range(0, /*agent.seatDict.Count*/1);
        if (agent.seatDict[agent.seatDict.ElementAt(randNum).Key] == false)
        {
        agent.navMeshAgent.destination = agent.seatDict.ElementAt(randNum).Key.transform.position;
            
            agent.seatDict[agent.seatDict.ElementAt(randNum).Key] = true;
            Debug.Log(agent.seatDict[agent.seatDict.ElementAt(randNum).Key]);
            Debug.Log(agent.seatDict.ElementAt(randNum).Key);
        }
        else
        {
            Debug.Log("123");
        }
        
        
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
