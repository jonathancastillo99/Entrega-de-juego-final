/* Este script tiene como función hacer que los enemigos "mueran" al ser alcanzados por el proyectil, que es la esfera llamada bala dentro de los prefabas  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DañoEne : MonoBehaviour
//Se declara la variable de la vida del jugador y se le asigna al objeto que lo representa
{

    /*Se indica que cuando haya una colisión del objeto con el script 
     (en este caso la bala), se busaque la tag y nombre del enemigo impactado para que sea 
     destruido dentro del juego*/

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(GameObject.Find("Enemigo"));
        }

        if (collision.gameObject.tag == "Enemigo0")
        {
            Destroy(GameObject.Find("Enemigo01"));
        }

        if (collision.gameObject.tag == "Enemigo1")
        {
            Destroy(GameObject.Find("Enemigo02"));
        }

        if (collision.gameObject.tag == "Enemigo2")
        {
            Destroy(GameObject.Find("Enemigo03"));
        }

        if (collision.gameObject.tag == "Enemigo3")
        {
            Destroy(GameObject.Find("Enemigo04"));
        }

        if (collision.gameObject.tag == "Enemigo4")
        {
            Destroy(GameObject.Find("Enemigo05"));
        }

        if (collision.gameObject.tag == "Enemigo5")
        {
            Destroy(GameObject.Find("Enemigo06"));
        }

        if (collision.gameObject.tag == "Enemigo 6")
        {
            Destroy(GameObject.Find("Enemigo07"));
        }

        if (collision.gameObject.tag == "Enemigo7")
        {
            Destroy(GameObject.Find("Enemigo08"));
        }

        if (collision.gameObject.tag == "Enemigo8")
        {
            Destroy(GameObject.Find("Enemigo09"));
        }

        if (collision.gameObject.tag == "Enemigo9")
        {
            Destroy(GameObject.Find("Enemigo10"));
        }

        if (collision.gameObject.tag == "Enemigo10")
        {
            Destroy(GameObject.Find("Enemigo11"));
        }

        if (collision.gameObject.tag == "Enemigo11")
        {
            Destroy(GameObject.Find("Enemigo12"));
        }

        if (collision.gameObject.tag == "Enemigo12")
        {
            Destroy(GameObject.Find("Enemigo13"));
        }

        if (collision.gameObject.tag == "Enemigo13")
        {
            Destroy(GameObject.Find("Enemigo14"));
        }

        if (collision.gameObject.tag == "Enemigo14")
        {
            Destroy(GameObject.Find("Enemigo15"));
        }
    }
    
}

