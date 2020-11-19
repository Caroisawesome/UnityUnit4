using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    public float horizontalInput;
    public int rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // rotationSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
