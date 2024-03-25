using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour
{
     public float scrollSpeed = 5f;

    void Update()
    {
        // Move the ground and background in the opposite direction of the player's movement
        float moveAmount = Time.deltaTime * scrollSpeed;
        transform.Translate(Vector2.left * moveAmount);

        // Check if the ground or background has moved out of view, then reset its position
        if (transform.position.x < -10f)  // Adjust the value based on your scene size
        {
            // Reset the position to create the illusion of continuous scrolling
            transform.position = new Vector2(0f, transform.position.y);
        }
    }
}
