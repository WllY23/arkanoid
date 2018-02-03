using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour 
{
	public bool pause;
	void Start () 
	{
		pause = false;
	}

	void Update () 
	{
		if (Input.GetKey (KeyCode.P)) 
		{
			if (pause == true) 
		    {
				pause = false;
			} 
			else 
			{
				pause = true;
				SceneManager.LoadScene ("MENU");
			}
		}
	}
}
