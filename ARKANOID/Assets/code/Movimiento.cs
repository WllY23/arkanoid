using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour 
{
	public Pause pausar;

	public float speed = 20.0F;
	public float translation;
	public float lim_x;
	public float lim_xn;

	void Start()
	{
	}
	void Update()
	{
		if (pausar.pause == true )
		{
			return;
		}
		translation = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime;
		if (translation > 0 && transform.position.x < lim_x) 
		{
			transform.Translate (Vector2.right * translation);
		}
		else if (translation < 0 && transform.position.x > lim_xn) 
		{
			transform.Translate(Vector2.right * translation);

		}
	}
}

