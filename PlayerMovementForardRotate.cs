using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementForardRotate : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 60f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
