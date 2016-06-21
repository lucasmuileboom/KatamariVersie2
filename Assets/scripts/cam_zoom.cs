using UnityEngine;
using System.Collections;

public class cam_zoom : MonoBehaviour 
{
	float Player = 0;

	void Update () 
	{
		if(collision.Player_Size > Player)
		{
			Player = collision.Player_Size;
			if (Player < 90) 
			{
				Camera.main.orthographicSize = Player / 3;
			}
		}
	}
}