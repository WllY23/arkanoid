using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviardann : MonoBehaviour {
	public int envdano;
	public Puntage danoo; 
	void OnCollisionEnter (Collision danho)
	{
		if (danho.collider.CompareTag ("Bola")) 
		{
			Enviarpuntos ();
		}
	}

	void Enviarpuntos ()
	{
		danoo.puntop1 ();
	}

//	void danio ()
//	{
//		danoo.puntop1 (envdano / 2);
//	}


}
  