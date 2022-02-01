using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [Header("Jump")]
    public bool isGrounded;
    public float rayLength;
    public float jumpForce;

    public LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, rayLength, ground))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            _rigidbody.velocity = Vector3.up * jumpForce;
        }
    }
}
