using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float WalkSpeed;
    private Rigidbody2D rb;
    [Header("MoveCameraPlayer")]
    public Camera cam;
    Vector2 MousePos;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal") * WalkSpeed * Time.deltaTime;
        float Vertical = Input.GetAxisRaw("Vertical") * WalkSpeed * Time.deltaTime;

        rb.velocity = new Vector2(Horizontal, Vertical);

        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Sprite();
    }

    void FixedUpdate()
    {
        float characterVelocityX = Mathf.Abs(rb.velocity.x);
        float characterVelocityY = Mathf.Abs(rb.velocity.y);

        animator.SetFloat("WalkSpeed", characterVelocityX);
        animator.SetFloat("WalkSpeed", characterVelocityY);

        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void Sprite()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            WalkSpeed = 2000;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            WalkSpeed = 1000;
        }
    }
}
