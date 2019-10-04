using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefinitePosition : MonoBehaviour
{

    public GameObject spawnTester;
    public GameObject spawnObject;
    public Vector3 centre;
    public Vector3 size;
    public int spawnCount;
    public float yPos;

    //Get central position
    //Start spawning method
    public void Start()
    {
        centre = GameObject.FindWithTag("Player").transform.position;
        StartCoroutine("SpawnObjects");
    }

    //Spawn a set number of objects in a defined area around the centre
    //Instantiate a collider to check if the space is free
    //If collider detects collision, space is not free, do not spawn
    //If no collision is detected, space is free, instantiate object
    IEnumerator SpawnObjects()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 pos = centre + new Vector3(Random.Range(-size.x / 2, size.x / 2), (yPos), Random.Range(-size.z / 2, size.z / 2));
            GameObject tester = Instantiate(spawnTester, pos, Quaternion.identity);
            yield return new WaitForFixedUpdate();
            
            if (tester.GetComponent<Collision_Test>().collisionBool == true)
            {
                Debug.Log("NoSpace");
                Destroy(tester);
                yield return null;
            }
            
            else
            {
                Debug.Log("Spawned");
                GameObject spawn = Instantiate(spawnObject, pos, spawnObject.transform.rotation);
                Destroy(tester);
                yield return spawn;
            }
        }
    }
}
