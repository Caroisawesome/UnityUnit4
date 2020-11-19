using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] spawnObjects;
    public int spawnIndex;
    public float time;
    public float repeatRate;
    public int xLowerBound;
    public int xUpperBound;
    public int yLowerBound;
    public int yUpperBound;
    public int zLowerBound;
    public int zUpperBound;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", time, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawner()
    {

      spawnIndex = Random.Range(0, spawnObjects.Length);
      int xPosition = Random.Range(xLowerBound,xUpperBound);
      int yPosition = Random.Range(yLowerBound,yUpperBound);
      int zPosition = Random.Range(zLowerBound,zUpperBound);

      Vector3 spawnPosition = new Vector3(xPosition,yPosition,zPosition);

      Instantiate(spawnObjects[spawnIndex], spawnPosition, spawnObjects[spawnIndex].transform.rotation);
    }
}
