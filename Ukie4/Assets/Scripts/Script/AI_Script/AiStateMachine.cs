using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiStateMachine 
{
    public AiState[] states;
    public AiAgent agent;
    public AiStateId currentState;

    public AiStateMachine(AiAgent agent)
    {
        this.agent = agent;
        int numStates = System.Enum.GetNames(typeof(AiStateId)).Length;
        states= new AiState[numStates];//using the number of states inside the enum in aistate to create an array
    }

    public void RegisterState(AiState state)
    {
        int index = (int)(state.GetId());
        states[index] = state;

    }
    public AiState GetState(AiStateId stateId) 
    { 
        int index = (int)stateId;
        return states[index];
    
    }
    public void Update()
    {
        if (GetState(currentState) != null)
        {
           // Debug.Log("changing state from the state machine " + currentState);
            GetState(currentState).Update(agent);
        }
       // GetState(currentState)?.Update(agent);

    }
    public void ChangeState(AiStateId newState)
    {
        GetState(currentState)?.Exit(agent);
        currentState = newState;
        GetState(currentState)?.Enter(agent);
    }
}
