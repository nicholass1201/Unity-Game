using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming the player has a "Player" tag
        {
            gameObject.SetActive(false); // Deactivate the object
        }
    }
}