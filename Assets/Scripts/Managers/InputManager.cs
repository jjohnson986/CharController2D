using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlatformerInput.IUIActions
{
    void PlatformerInput.IUIActions.OnNewaction(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
