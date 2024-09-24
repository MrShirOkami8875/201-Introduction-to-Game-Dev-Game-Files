using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Movement direction
        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1f; // Move right
        }

        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1f; // Move up
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vertical = -1f; // Move down
        }

        // Movement vector
        Vector2 movement = new Vector2(horizontal, vertical).normalized;

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
