using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public InputActionProperty moveInput;

    void Update()
    {
        Vector2 move = moveInput.action.ReadValue<Vector2>();

        transform.Translate(move.x * moveSpeed * Time.deltaTime, 0, move.y * moveSpeed * Time.deltaTime);

    }
}
