using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnDistance = 5;
    public float spawnInitialDelay = 2;
    public float spawnDelay = 0.75f;
    public GameObject[] spawnedObjs;
    public GameObject spawnedObj; // Aggregate Relationship -- 'Spawner has a spawnedObj'
    public GameObject boss;
    
    
    // ---------- Start() -----------
    void Start()
    {
        //SpawnObject();
        //Invoke("SpawnObject", 1); // spawn after 1 second
        // initial wait time 2 sec followed by spawning every 1 sec
        InvokeRepeating("SpawnObject", spawnInitialDelay, spawnDelay); // run function 'again and again' every 1 sec
        //Invoke("Boss" , 5);
    }

    public void SpawnObject()
    {
        Vector3 newPos = Random.insideUnitCircle.normalized * spawnDistance;
        spawnedObj = spawnedObjs[Random.Range(0, spawnedObjs.Length)];
        Instantiate(spawnedObj, transform.position + newPos, transform.rotation);
    }
    
    public void Boss()
    {
        Vector3 newPos = Random.insideUnitCircle.normalized * spawnDistance;
        spawnedObj = boss; //spawnedObjs[Random.Range(0, spawnedObjs.Length)];
        Instantiate(spawnedObj, transform.position + newPos, transform.rotation);
    }
    
    // New Input System
}
