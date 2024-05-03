using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Rigidbody _rb;
    float _walkSpeed;
    float _inputHorizontal;
    float _inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
        _walkSpeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _inputVertical = Input.GetAxisRaw("Vertical");
 

        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector3(_inputHorizontal * _walkSpeed, 0f, 0f));

        }
        if (_inputVertical != 0)
        {
            _rb.AddForce(new Vector3(0f, 0f, _inputVertical * _walkSpeed));

        }
    }
}
