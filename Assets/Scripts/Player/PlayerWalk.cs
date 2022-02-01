using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private CommandContainer commandContainer;
    
    [Header("Movement")]
    public float moveSpeed;

    public float gravity;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        _rigidbody.velocity = new Vector3(moveSpeed * horizontalinput, _rigidbody.velocity.y + gravity, 0);
    }
}