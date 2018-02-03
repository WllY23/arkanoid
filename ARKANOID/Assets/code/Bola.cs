using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour 
{
	public Puntage vidapunta;
	public bool estasacando;
	public Transform spawpoint;
	public Pause pausar;
	Vector2 starPosition;
	public float velocidad_ini;
	public float velocidad_x;
	public float limite_x;
	public float limite_xn;
	public float velocidad_y;
	public float limite_y;
	public float limite_yn;
	public bool lim_x;
	public bool lim_y;
	public GameObject bolita;
	public Vector2 salida;
	public Puntage punto;

//	public GameObject bolita;
	public float limite;
//	public Vector2 salida;

	public void Start () 
	{
     	starPosition = transform.position; 
      	velocidad_ini = velocidad_x;
	}
		
	void OnTriggerEnter2D (Collider2D  contacto)
	{
		if (contacto.gameObject.tag == "Player")
		{
			lim_y=true;
			velocidad_y +=0.3f;
		}

		if (contacto.gameObject.tag == "Ladrillo")
		{
			contacto.gameObject.SetActive(false);
			float dir_y = transform.position.y - contacto.transform.position.y;
			float dir_x = transform.position.y - contacto.transform.position.x;
			if (dir_x > 0) 
			{
				lim_x = true;
			}
			else
			{
				lim_x = false;
			}
			if (dir_y > 0) 
			{
				lim_y = true;
			}
			else
			{
				lim_y = false;
			}
			punto.puntop1 ();
		}


		if (contacto.gameObject.tag == "Ladrillo2")
		{
			contacto.gameObject.SetActive(false);
			float dir_y = transform.position.y - contacto.transform.position.y;
			float dir_x = transform.position.y - contacto.transform.position.x;
			if (dir_x > 0) 
			{
				lim_x = true;
			}
			else
			{
				lim_x = false;
			}
			if (dir_y > 0) 
			{
				lim_y = true;
			}
			else
			{
				lim_y = false;
			}
			punto.puntop2 ();
		}

		if (contacto.gameObject.tag == "Ladrillo3")
		{
			contacto.gameObject.SetActive(false);
			float dir_y = transform.position.y - contacto.transform.position.y;
			float dir_x = transform.position.y - contacto.transform.position.x;
			if (dir_x > 0) 
			{
				lim_x = true;
			}
			else
			{
				lim_x = false;
			}
			if (dir_y > 0) 
			{
				lim_y = true;
			}
			else
			{
				lim_y = false;
			}
			punto.puntop3 ();
		}

		if (contacto.gameObject.tag == "Ladrillo4")
		{
			contacto.gameObject.SetActive(false);
			float dir_y = transform.position.y - contacto.transform.position.y;
			float dir_x = transform.position.y - contacto.transform.position.x;
			if (dir_x > 0) 
			{
				lim_x = true;
			}
			else
			{
				lim_x = false;
			}
			if (dir_y > 0) 
			{
				lim_y = true;
			}
			else
			{
				lim_y = false;
			}
			punto.puntop4 ();
		}
	}
		

	public void Update ()

	{
		if (pausar.pause == true )
		{
			return;
		}

		if (estasacando) 
		{
			transform.position = spawpoint.position;
			velocidad_x = 0;
			velocidad_y = 0;
			if (Input.GetButtonDown ("Jump"))
			{
				estasacando = false;
				velocidad_x = velocidad_ini;
				velocidad_y = velocidad_ini;
			}
		}

		if (lim_x == true) 
		{
			transform.Translate (Vector2.right * (velocidad_x * Time.deltaTime));
			if (transform.position.x > limite_x) 
			{
				lim_x = false;
			//bolita.transform.position = salida;
			//	velocidad_x = velocidad_ini;
			}

		} else 
		{
			transform.Translate (Vector2.left * (velocidad_x * Time.deltaTime));
			if (transform.position.x < limite_xn) 
			{
				lim_x = true;
			//	bolita.transform.position = salida;	
			//	velocidad_x = velocidad_ini;
			}
		}
		if (lim_y == true) 
		{
			transform.Translate (Vector2.up * (velocidad_y * Time.deltaTime));
			if (transform.position.y > limite_y) 
			{
				lim_y = false;
			}
		}
		   else 
		{
			transform.Translate (Vector2.down * (velocidad_y * Time.deltaTime));
			if (transform.position.y < limite_yn) 
			{
				vidapunta.puntovida ();
				estasacando = true;
			}
		}
	 }
}


