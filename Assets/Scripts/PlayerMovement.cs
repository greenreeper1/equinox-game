using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, moveInput.y, 0).normalized;
        transform.Translate(move * speed * Time.deltaTime);
    }
}
