using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	
	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}
}