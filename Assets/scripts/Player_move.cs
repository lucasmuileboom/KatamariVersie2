using UnityEngine;
using System.Collections;

public class Player_move : MonoBehaviour {

	public float Speed = 6;

	void Update () 
	{
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate (Vector3.down * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate (Vector3.up * Speed * Time.deltaTime);
		}
	}
}