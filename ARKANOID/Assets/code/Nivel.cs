using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour
{
	public	float distanciahorizontal;
	public float distanciavertical;
	// el textasset es el documento de bloc de notas que creo para los niveles
	public TextAsset nive_1;
	// el string[] nombre es un array que creo para dar el orden  la secuencia de la matris para imprimir los cuadros 
	public string[] nombres;
	// el ladrillo es el que desde el siclo para me duplica para poder hacer en el orden de la matriz del nivel
	public GameObject ladrillo;
	public int cant_i;
	public int cant_j;

	void Start () 
	{
//		for (int i = 0; i < nombres.Length; i++) 
//		{
//			print (nombres[i]);
//		}
		for (int i = 0; i < cant_i; i++) 
		{
			// instantiate el this.transform  es para hacer de hijo al ladrillo del objeto vacio que es el go
		//	GameObject go = Instantiate(ladrillo,this.transform);
			// i es x y 0 es y en el vector2 del new
			//go.transform.position =  new Vector2(i,0);
			for (int j = 0; j < cant_j; j++)
			{
				GameObject go = Instantiate(ladrillo,this.transform);
				go.transform.localPosition = new Vector2 (i*distanciavertical,j*distanciahorizontal);
			}
		}
	}
	void Update () 
	{
		
	}
}
 