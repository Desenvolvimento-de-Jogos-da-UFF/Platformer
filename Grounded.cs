using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    [SerializeField] private PlayerMovementScript playerMovement;


    private void OnTriggerEnter2D(Collider2D other)
    {

        playerMovement.isGrounded = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {

        playerMovement.isGrounded = false;

    }
}
