using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyOnCollison : MonoBehaviour
{
    public bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("dsd");
        if (other.gameObject.tag == "Player")
        {
            inRange = true;
            Debug.Log("player has entered the enemy zone");
        }
    }

}
