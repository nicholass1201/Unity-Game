using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float interactionDistance = 3f;
    public float moveSpeed = 1f; // Speed at which the cube moves
    public float moveDistance = 1f; // Distance the cube moves upward

    private bool isMoving = false; // Flag to track if the cube is currently moving

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isMoving)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactionDistance))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Interact();
                }
            }
        }

        // Move the cube upward if it's currently moving
        if (isMoving)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

            // Check if the cube has reached its target position
            if (transform.position.y >= (transform.position.y + moveDistance))
            {
                isMoving = false; // Stop moving once it reaches the target position
            }
        }
    }

    void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        // Add your interaction logic here

        // Start moving the cube upward
        isMoving = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionDistance);
    }
}
