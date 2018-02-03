using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntage : MonoBehaviour 
{
	public int valorpuntage;
	public int valorpuntage2;
	public int valorpuntage3;
	public int valorpuntage4;
	public int puntosvida = 3;
	public Text vidas;
	public static int puntos = 0 ;
	public Text play1;



	public void puntop1 ()
	{
		//puntos = puntos + valorpuntage;
		General.puntos = General.puntos + valorpuntage;
		//play1.text = puntos.ToString();
	 	play1.text = "Punto: " + General.puntos.ToString();
		if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 12400) 
		{
			SceneManager.LoadScene ("MENU");
		}
		if (General.puntos == 200)
		{
			puntosvida = puntosvida + 1;
			vidas.text = puntosvida.ToString();
		}
	}

	public void puntop2 ()
	{
		General.puntos = General.puntos + valorpuntage2;
		play1.text = "Punto: " + General.puntos.ToString();
		if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}
		if (General.puntos == 200)
		{
			puntosvida = puntosvida + 1;
			vidas.text = puntosvida.ToString();
		}
	}

	public void puntop3 ()
	{
		General.puntos = General.puntos + valorpuntage3;
		play1.text = "Punto: " + General.puntos.ToString();
		if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}
		if (General.puntos == 200)
		{
			puntosvida = puntosvida + 1;
			vidas.text = puntosvida.ToString();
		}
	}

	public void puntop4 ()
	{
		General.puntos = General.puntos + valorpuntage4;
		play1.text = "Punto: " + General.puntos.ToString();
		if (General.puntos == 1600) 
		{
			SceneManager.LoadScene ("Nivel_2");
		}
		if (General.puntos == 3000) 
		{
			SceneManager.LoadScene ("Nivel_3");
		}
		if (General.puntos == 9000) 
		{
			SceneManager.LoadScene ("MENU");
		}
		if (General.puntos == 200)
		{
			puntosvida = puntosvida + 1;
			vidas.text = puntosvida.ToString();
		}
	}


	public void puntovida ()
	{
		puntosvida = puntosvida - 1;
		vidas.text = puntosvida.ToString ();
		if (puntosvida <= 0)
		{
			SceneManager.LoadScene ("GameOver");
		}
	}
}

