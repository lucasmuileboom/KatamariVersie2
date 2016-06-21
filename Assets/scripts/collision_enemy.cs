using UnityEngine;
using System.Collections;

public class collision_enemy : MonoBehaviour 
{
	private bool collectedOtherEnemy = false;
	private bool collectedEnemy = false;
	float EnemySize1 = 2;
	size Enemy = new size ();
	size otherEnemy = new size ();

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "collectable1")
		{
			Enemy = gameObject.GetComponent<size> ();
			collectedEnemy = true;
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "wall")
		{
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "collectable") 
		{
			otherEnemy = other.gameObject.GetComponent<size> ();
			if(Enemy.Enemy_Size > otherEnemy.Enemy_Size)
			{
				collectedOtherEnemy = true;
				Destroy (other.gameObject);
			}
		}

	}	

	void Update () 
	{
		if (collectedEnemy == true) 
		{
			
			gameObject.transform.localScale = new Vector3 (Enemy.Enemy_Size/20, Enemy.Enemy_Size/20, 1);
			collectedEnemy = false;
		}
		if(collectedOtherEnemy == true)
		{
			Enemy.Enemy_Size = otherEnemy.Enemy_Size + Enemy.Enemy_Size;
			gameObject.transform.localScale = new Vector3 (Enemy.Enemy_Size/20, Enemy.Enemy_Size/20, 1);
			collectedOtherEnemy = false;
		}
	}
}




