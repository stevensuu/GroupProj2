using UnityEngine;

public class CharacterRootMotion : MonoBehaviour
{
    private Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component
        lastPosition = transform.position;  // Store the initial position
    }

    void Update()
    {
        animator.applyRootMotion = true;  // Ensure root motion is applied

        // Prevent Unity from resetting position
        Vector3 deltaPosition = transform.position - lastPosition;
        if (deltaPosition.magnitude < 0.01f)
        {
            transform.position += transform.forward * 0.1f;  // Small forward adjustment
        }

        lastPosition = transform.position;  // Update last position
    }
}
