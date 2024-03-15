using UnityEngine;
using System.Collections;

public class TrainController : MonoBehaviour
{
    public float timeStationary = 5f; // Time to wait with doors open
    public float timeMoving = 5f; // Time to move before stopping
    private Animator animator;
    private bool isTrainStationary = true; // We start with the train stationary

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        // Start the routine
        StartCoroutine(TrainRoutine());
    }

    private IEnumerator TrainRoutine()
    {
        while (true) // Infinite loop to handle the train routine
        {
            if (isTrainStationary)
            {
                // Open doors
                animator.SetBool("DoorOpen", true);
                yield return new WaitForSeconds(timeStationary);
                
                // Close doors
                animator.SetBool("DoorOpen", false);
                animator.SetBool("DoorClose", true);
                // Wait for the doors to close animation
                yield return new WaitForSeconds(timeStationary);
                animator.SetBool("DoorClose", false);

                // Start moving
                animator.SetBool("TrainIsMoving", true);
                isTrainStationary = false;
                yield return new WaitForSeconds(timeMoving);
            }
            else
            {
                // Stop moving
                animator.SetBool("TrainIsMoving", false);
                isTrainStationary = true;
                // Wait a bit before opening doors again
                yield return new WaitForSeconds(timeStationary);
            }
        }
    }
}
