/* Este script tiene como finalidad que los ítems desaparezcan tras ser "recogidos" por el jugador*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestItems : MonoBehaviour
{

    //Se indica que cuando el jugador impacte con algún objeto con cierta etiqueta, y al objeto al que corresponde ésta sea destruido
   
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Vendas")
        {
            Destroy(GameObject.Find("Vendaje"));
        }

        if (collision.gameObject.tag == "Vendas01")
        {
            Destroy(GameObject.Find("Vendaje01"));
        }

        if (collision.gameObject.tag == "Municion")
        {
            Destroy(GameObject.Find("Municion"));
        }

        if (collision.gameObject.tag == "Municion1")
        {
            Destroy(GameObject.Find("Municion01"));
        }
    }

}