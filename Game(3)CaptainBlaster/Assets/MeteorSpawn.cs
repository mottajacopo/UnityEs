using UnityEngine;
using System.Collections;

public class MeteorSpawn : MonoBehaviour {
	public float minSpawnDelay = 1f;
	public float maxSpawnDelay = 3f;
	public GameObject meteorPrefab;

	void Start () {
		Spawn ();
	}

	void Spawn () {
		// The meteor is spawned at the same y and z coordinate as the spawn point, 
		// but the x coordinate is offset by a number between −6 and 6. To allow 
		// the meteors to spawn across the screen and not always in the same spot.
		Vector3 spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 10, 0);
		
		// Instantiates (creates) a meteor at that position with no rotation (Quaternion.identity). 
		Instantiate (meteorPrefab, spawnPos, Quaternion.identity);
		
		// Invokes a call to the spawn function again, after a random amount of time, 
		// controlled by our two timing variables.
		Invoke ("Spawn", Random.Range (minSpawnDelay, maxSpawnDelay));
	}
}