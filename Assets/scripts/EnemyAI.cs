using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	private bool walls = false;
	public float Speed = 5;
	float random = 0;
	float timer = 0f;
	private bool AI1 = false;
	private bool AI2 = false;
	private bool AI3 = false;
	private bool AI4 = false;

	void Update () 
	{
		timer -= Time.deltaTime;


		if (timer <= 0) 
		{
			AI1 = false;
			AI2 = false;
			AI3 = false;
			AI4 = false;

			random = Random.Range (0f, 4f);

			if (random <= 1) 
			{
				AI1 = true;
			}
			else if (random <= 2) 
			{
				AI2 = true;
			}
			else if (random <= 2) 
			{
				AI3 = true;
			}
			else if (random <= 4) 
			{
				AI4 = true;
			}
			timer = 1f;
		}
		if (AI1 == true)
		{
			transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}
		else if (AI2 == true)
		{
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		else if (AI3 == true)
		{
			transform.Translate (Vector3.down * Speed * Time.deltaTime);
		}
		else if (AI4 == true)
		{
			transform.Translate (Vector3.up * Speed * Time.deltaTime);
		}
	}
}