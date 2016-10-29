using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour {

    //Bonus Spawn
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;
    public GameObject mum;                // The enemy prefab to be spawned.
    // Use this for initialization
    void Start()
    {
        //Enemy Spawn
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Determines the spawn time and location of enemies.
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(mum, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}

