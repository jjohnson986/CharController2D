using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour, PlatformerInput.IPlayerActions
{
    private PlatformerInput _input;
    private SpriteRenderer spriteRenderer;

    public Vector2 MovementVector {  get; private set; }

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        OnPlayerSpawn();
    }

    void Update()
    {
        FaceDirection();
    }

    void FaceDirection()
    {
        if (MovementVector.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (MovementVector.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    public void OnPlayerSpawn()
    {
        _input = new PlatformerInput();
        _input.Player.SetCallbacks(this);
        _input.Player.Enable();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementVector = context.ReadValue<Vector2>();
    }
}
