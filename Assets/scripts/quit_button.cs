using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class quit_button : MonoBehaviour
{
	void Update() 
	{
		if (Input.GetKey ("escape")) 
		{
			Application.Quit ();
		}
	}
}