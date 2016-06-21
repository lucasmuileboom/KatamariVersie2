using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
	public GameObject Enemy;
	public float SpawnSpeed;

	void Start()
	{
		InvokeRepeating("Spawning", 0, SpawnSpeed);
	}


	void Spawning()
	{
		int x = Random.Range(0, 200);
		int y = Random.Range(0, 200);

		Vector3 Target = new Vector3(x, y, 0);
		Target.z = 0;

		Instantiate(Enemy, Target, Quaternion.identity);
	}
}