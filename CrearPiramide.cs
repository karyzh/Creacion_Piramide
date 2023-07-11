using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPiramide : MonoBehaviour
{
    public GameObject Objeto; //se crea un cubo de tipo objeto
    public int ancho = 9;

    private int conteo1 = 0, conteo3 = 0;
    private float conteo2 = 0.5f;

    IEnumerator LluviadeCubos()
    {
        Quaternion Angulo = Quaternion.identity; //quaternion son para los ángulos -- .identity significa que será fijo, es decir, no se moverá

    for (int y = 0; y < (ancho); y++)
        {
            for (int x = 0; x < (ancho-conteo1); x++)
            {
                for (int z= 0; z < (ancho-conteo1); z++)
                {
                    Instantiate (Objeto, new Vector3( x+conteo2, 5.0f+conteo3, z+conteo2 ), Angulo);
                    yield return new WaitForSeconds(0.03f);
                }
            }
            conteo1=conteo1+1;
            conteo2=conteo2+0.5f;
            conteo3=conteo3+1;
        }
    }

    //Start es llamado antes de la primera actualización del cuadro
    void Start()
    {
        StartCoroutine(LluviadeCubos());
    }
}