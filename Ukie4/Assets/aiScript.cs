using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiScript : MonoBehaviour
{
    public GameObject Seat;
    // Start is called before the first frame update
    void Start()
    {
        Seat = GameObject.FindGameObjectWithTag("Seat");
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent navmesh = GetComponent<NavMeshAgent>();
        navmesh.destination = Seat.transform.position;
    }
}
