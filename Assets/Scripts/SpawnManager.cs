using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnObjects;    
    public float startDelay;
    public float repeatRate;
    public float xLowerBound;
    public float xUpperBound;
    public float yLowerBound;
    public float yUpperBound;
    public float zLowerBound;
    public float zUpperBound;

    private int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawner()
    {
      spawnIndex = Random.Range(0, spawnObjects.Length);

      float xPosition = Random.Range(xLowerBound,xUpperBound);
      float yPosition = Random.Range(yLowerBound,yUpperBound);
      float zPosition = Random.Range(zLowerBound,zUpperBound);

      Vector3 spawnPosition = new Vector3(xPosition,yPosition,zPosition);

      Instantiate(spawnObjects[spawnIndex], spawnPosition, spawnObjects[spawnIndex].transform.rotation);
    }
}
