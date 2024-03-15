using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterLocomotion : MonoBehaviour
{
    Animator animator;
    Vector2 input;
    
    // Start is called before the first frame update
    void Start()
    {
        
       animator =  GetComponent<Animator>();
    }

    public float turnSpeed = 90f; // Adjust this value to control turning speed
    public float moveSpeed = 5f; // Adjust this value to control movement speed
   

    void Update()
    {
        // Check for input to turn left or right
        if (Input.GetKeyDown(KeyCode.A))
        {
            Turn(-1); // Turn left
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Turn(1); // Turn right
        }

        // Move the player forward only when the forwardKey is pressed
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsMoving", true);
            Move();
        }
        else
            animator.SetBool("IsMoving", false);
    }

    void Turn(float direction)
    {
        // Calculate the rotation amount based on turn speed and direction
        float angle = direction * 180f;

        // Apply rotation to the player object
        transform.Rotate(Vector3.up, angle);
    }

    void Move()
    {
        // Move the player in the forward direction
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
