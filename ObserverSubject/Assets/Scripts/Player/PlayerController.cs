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

        _MoveForce = new Vector3(0, 0.0f, _InputZ);
        _MoveForce = _MoveForce * _MoveSpeed * Time.deltaTime;

        _InputZ = _InputZ * _MoveSpeed * Time.deltaTime;

        _RotationForce = _InputX * _Sensitivity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + _RotationForce, transform.rotation.eulerAngles.z);
        _rb.AddForce(transform.forward * _InputZ, ForceMode.Impulse);
    }
}
