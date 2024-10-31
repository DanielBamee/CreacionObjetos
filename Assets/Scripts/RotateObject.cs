using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed;

    void Update()
    {
        if (Input.GetKey("."))
        {
            float rotationAmount = Time.deltaTime * rotationSpeed;
            transform.Rotate(Vector3.up * rotationAmount);
        }
        if (Input.GetKey(","))
        {
            float rotationAmount = Time.deltaTime * rotationSpeed;
            transform.Rotate(Vector3.down * rotationAmount);
        }
    }
}