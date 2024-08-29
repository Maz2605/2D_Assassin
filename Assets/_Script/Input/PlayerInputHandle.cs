using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandle : MonoBehaviour
{
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        Debug.Log("Movement");
    }
    public void OnJumpInput(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
    }
}
