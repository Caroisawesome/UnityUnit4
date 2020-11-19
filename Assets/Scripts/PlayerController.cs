using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float verticalInput;
    public Rigidbody playerRigidBody;
    private int moveSpeed;
    private GameObject focalPoint;

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


    }
}
