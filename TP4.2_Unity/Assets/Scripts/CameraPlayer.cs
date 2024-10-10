using UnityEngine;
using UnityEngine.InputSystem;

public class CameraPlayer : MonoBehaviour
{
    public float turnSpeed = 90.0f;
    public InputActionProperty turnInput;

    void Update()
    {
        Vector2 turn = turnInput.action.ReadValue<Vector2>();

        transform.Rotate(0, turn.x * turnSpeed * Time.deltaTime, 0);

    }
}
