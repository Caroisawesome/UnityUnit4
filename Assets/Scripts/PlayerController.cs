using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public Rigidbody playerRigidBody;
    private int moveSpeed;

    private float verticalInput;
    private GameObject focalPoint;

    [Range(0.5f, 3.0f)]
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        playerRigidBody.AddForce(focalPoint.transform.forward * moveSpeed* verticalInput);

        transform.localScale = new Vector3(scale, scale, scale);
    }
}
