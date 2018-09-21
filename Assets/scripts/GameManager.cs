using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> critterPrefabs;
    public float critterSpawnFrequency = 1.0f;
    public Score ScoreDisplay;

    private float lastCritterSpawn = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float nextSpawnTime = lastCritterSpawn + critterSpawnFrequency;
		if (Time.time >= lastCritterSpawn + critterSpawnFrequency) {

            //It is time.

            //Choose a random critter to spawn.
            int critterIndex = Random.Range(0, critterPrefabs.Count);
            GameObject prefabToSpawn = critterPrefabs[critterIndex];

            //spawn the critter.
            GameObject spawnedCritter = Instantiate(prefabToSpawn);

            //Get Access to our critter script
            Critter critterScript = spawnedCritter.GetComponent<Critter>();

            //Tell the critter script the score object
            critterScript.scoreDisplay = ScoreDisplay;

            //Update the most recent critter spawn time.
            lastCritterSpawn = Time.time;

        }
	}
}
