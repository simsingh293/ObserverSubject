using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;

    public float _InputX;
    public float _InputZ;

    Vector3 _MoveForce;
    public float _MoveSpeed = 5.0f;

    public float _RotationForce = 0f;
    public float _Sensitivity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        _InputX = Input.GetAxis("Horizontal");
        _InputZ = Input.GetAxis("Vertical");

        _RotationForce = _InputX * _Sensitivity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + _RotationForce, transform.rotation.eulerAngles.z);

        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = transform.forward * _MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _rb.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.velocity = -transform.forward * _MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            _rb.velocity = Vector3.zero;
        }
    }
}
