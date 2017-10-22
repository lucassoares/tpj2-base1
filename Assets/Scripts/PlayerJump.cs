using UnityEngine;

public sealed class PlayerJump : MonoBehaviour
{
    public PlayerController controller;
    public KeyCode inputPular;

    public float jumpImpulse = 15.0f;

    private void Start()
    {
        Inpu.pulo = inputPular;
    }
    private void Update()
    {
        if (controller.isGrounded && !controller.isStunned && Inpu.GetPulo())
            controller.playerRigidbody.AddForce(new Vector2(0.0f, jumpImpulse), ForceMode2D.Impulse);
    }
}
