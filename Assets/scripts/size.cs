using UnityEngine;
using System.Collections;

public class size : MonoBehaviour 
{
	public float Enemy_Size = 0;

	void Start ()
	{
		Enemy_Size =  Random.Range (50f, 150f);
		gameObject.transform.localScale = new Vector3 (Enemy_Size/20, Enemy_Size/20, 1);
	}
}