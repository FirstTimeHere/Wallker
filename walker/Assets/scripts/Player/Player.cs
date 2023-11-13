using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public abstract class Player : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float groundDrag;

    [Header("Ground Check")]
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask whatIsGround;


    [Header("Jump")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float jumpCooldown;
    [SerializeField] private float airMultiplier;

    private bool isGrounded;
    private bool readyToJump = true;


    private KeyCode jumpKey = KeyCode.Space;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    protected virtual void Move(Transform orientation, float speed = 5f)
    {
        float zMove = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float yMove = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        if (Input.GetKey(jumpKey) && readyToJump && isGrounded)
        {
            readyToJump = false;

            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }

        Vector3 moveDirectiopn = orientation.forward * yMove + orientation.right * zMove;

        if (isGrounded)
        {
            rb.AddForce(moveDirectiopn.normalized * speed * 10f, ForceMode.Force);
        }
        else if (!isGrounded)
        {
            rb.AddForce(moveDirectiopn.normalized * speed * 10f * airMultiplier, ForceMode.Force);
        }

        SpeedControl(speed);

    }

    protected void Grounded()
    {
        //ground check

        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void SpeedControl(float speed)
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limited velocity if needed

        if (flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    protected virtual void Jump()
    {
        //reset y velocity

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private bool ResetJump()
    {
        return readyToJump = true;
    }
}
