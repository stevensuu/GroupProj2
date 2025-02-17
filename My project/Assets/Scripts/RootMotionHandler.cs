using UnityEngine;

public class RootMotionHandler : MonoBehaviour
{
    public Animator animator;  // Now it's public, so you can assign it in the Inspector

    void Start()
    {
        if (animator == null)
            animator = GetComponent<Animator>();  // Auto-assign if not manually set
    }

    void Update()
    {
        animator.applyRootMotion = true;  // Forces Unity to use root motion
    }
}
