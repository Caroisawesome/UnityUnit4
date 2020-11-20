using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rigidBody;
    private GameObject player;

    public int speed;

    //in the case of prefabs being instantiated (i.e. spawning), does not
    //change for the prefab after spawn, but will affect next spawn
    [Range(0.5f, 3.0f)]
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        rigidBody.AddForce( direction * speed);

        transform.localScale = new Vector3(scale, scale, scale);
    }
}
