using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collision : MonoBehaviour 
{
	
	public static float Player_Size = 10;
	float Score = 0;
	float Enemy1_Size = 2;

	private bool collected = false;
	private bool collected1 = false;

	public Text scoreText;

	size Enemy = new size ();

	void Start ()
	{
		Player_Size = 10;
		gameObject.transform.localScale = new Vector3 (Player_Size/20, Player_Size/20, 1);
		Score = Player_Size - 10;
		scoreText.text = "Score: " + Score.ToString();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "collectable1")
		{
			collected1 = true;
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "collectable")
		{
			Enemy = other.GetComponent<size> ();
			if (Player_Size >= Enemy.Enemy_Size && other.gameObject.tag == "collectable") 
			{
				collected = true;
				Destroy (other.gameObject);
			}
			if (Player_Size <= Enemy.Enemy_Size && other.gameObject.tag == "collectable") 
			{
				Application.LoadLevel("RestartScreen");
			}
		}
	}

	void Update()
	{
		if (collected == true) 
		{
			Player_Size = Player_Size + Enemy.Enemy_Size ;
			Score = Player_Size - 10;
			scoreText.text = "Score: " + Score.ToString();
			gameObject.transform.localScale = new Vector3 (Player_Size/20, Player_Size/20, 1);
			if(Player_Size/20>100)
			{
				Application.LoadLevel("WinScreen");
			}
			collected = false;
		}

		if (collected1 == true) 
		{
			Player_Size = Player_Size + Enemy1_Size ;
			Score = Player_Size - 10;
			scoreText.text = "Score: " + Score.ToString();
			gameObject.transform.localScale = new Vector3 (Player_Size/20, Player_Size/20, 1);
			collected1 = false;
		}
	}
}