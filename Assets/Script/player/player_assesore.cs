using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f; // Velocità di movimento del personaggio

    // Update viene chiamato ad ogni frame
    void Update()
    {
        // Ottieni l'input orizzontale e verticale dalle frecce della tastiera
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcola la direzione di movimento
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Applica il movimento relativo alla velocità e al tempo
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
