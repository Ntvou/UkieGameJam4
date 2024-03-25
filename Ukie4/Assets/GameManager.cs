using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int NPCSpawned;
    [SerializeField] GameObject NpcPrefab;
    [SerializeField] GameObject[] spawnPoints;

    private void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Exit");
    }

    public void SpawnNpcs(int numNpcs)
    {
        for(int i=0; i<numNpcs; i++)
        {
            GameObject spawnPoint = spawnPoints[Random.Range(0,spawnPoints.Length)];

            Instantiate(NpcPrefab,spawnPoint.transform.position,Quaternion.identity);

            NPCSpawned++;
           
        }
    }


}
