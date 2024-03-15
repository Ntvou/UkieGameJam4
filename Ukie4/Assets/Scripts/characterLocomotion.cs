using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    Animator animator;
    bool isFacingLeft = false; // Track if character is facing left
    bool isFacingRight = false; // Track if character is facing right

    public float turnSpeed = 90f; // Adjust this value to control turning speed
    public float moveSpeed = 5f; // Adjust this value to control movement speed

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for input to turn left or right
        if (Input.GetKeyDown(KeyCode.A) && !isFacingLeft)
        {
            Turn(1); // Turn left
            isFacingLeft = true; // Now facing left
            isFacingRight = false; // Not facing right
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isFacingRight)
        {
            Turn(-1); // Turn right
            isFacingRight = true; // Now facing right
            isFacingLeft = false; // Not facing left
        }

        // Move the player forward only when the forwardKey is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsMoving", true);
            Move();
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
    }

    void Turn(float direction)
    {
        // Only rotate character by 90 degrees to face left or right
        float angle = direction * 90f; // Use 90 degrees for exact left or right turn

        // Apply rotation to the player object to face the new direction
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

    void Move()
    {
        // Move the player in the forward direction
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
