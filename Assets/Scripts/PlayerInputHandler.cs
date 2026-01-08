using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private Rigidbody ballRb;
    public Vector2 moveInput;

    private Vector3 direction;
    private float kickForce = 5f;

    public void OnKick(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Kick started");
            ballRb.AddForce(direction * kickForce, ForceMode.Impulse);
        }

        if (context.canceled)
        {
            Debug.Log("Kick done");
        }
    }
    public void Moving(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

 
}
