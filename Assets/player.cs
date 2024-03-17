using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocità di movimento del personaggio

    // Update viene chiamato ad ogni frame
    void Update()
    {
        // Input orizzontale (tasti A e D)
        float horizontalInput = Input.GetAxis("Horizontal");
        // Input verticale (tasti W e S)
        float verticalInput = Input.GetAxis("Vertical");

        // Calcoliamo la direzione di movimento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Applichiamo il movimento al transform del personaggio
        transform.Translate(movement);
    }
}