using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform player;       // Reference to the player
    public float speed = 2f;        // Initial speed of the NPC
    public float maxSpeed = 10f;    // Maximum speed the NPC can reach
    public float acceleration = 0.1f; // Rate at which the NPC speeds up
    public float turnSpeed = 5f;    // Speed at which the NPC turns

    private float currentSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
    }

    void FixedUpdate()
    {
        if (player == null) return;

        // Calculate the direction to the player
        Vector2 direction = (player.position - transform.position).normalized;

        // Rotate NPC to face the player gradually
        float step = turnSpeed * Time.deltaTime;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float angle = Mathf.LerpAngle(transform.eulerAngles.z, targetAngle, step);
        transform.eulerAngles = new Vector3(0, 0, angle);

        // Increase speed over time
        currentSpeed = Mathf.Min(currentSpeed + acceleration * Time.deltaTime, maxSpeed);

        // Apply the movement
        rb.velocity = direction * currentSpeed;
    }
}