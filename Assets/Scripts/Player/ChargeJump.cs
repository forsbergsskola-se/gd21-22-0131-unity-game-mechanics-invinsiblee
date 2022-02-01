using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeJump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    private PlayerInputController inputController;
    [Header("Jump")] 
    public float minimumJumpForce = 200;
    public float maximumJumpForce = 1000;
    public float jumpChargeTime = 1f;
    public bool isGrounded;
    public float rayLength;
    public float jumpForce;
    private float chargeProgress = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    private void Jump()
    {
        
        Debug.DrawRay(transform.position, Vector3.down * rayLength, Color.black);
        //Jump
        if (Physics.Raycast(transform.position, Vector3.down, rayLength))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        
        //If holding button we charge
        if (inputController.jumpInputDown)
        {
            chargeProgress += Time.deltaTime / jumpChargeTime;
        }

        if ((inputController.jumpInputUp) == isGrounded)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, chargeProgress);

            chargeProgress = 0f;
            if (isGrounded)
            {
                _rigidbody.AddForce(0, jumpForce, 0);
            }
        }
    }
}