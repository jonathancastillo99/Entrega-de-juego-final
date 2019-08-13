/* Este script funcionará para que el jugador pueda disparar  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisparoJ : MonoBehaviour
//Se declara qué objeto será el proyectil, de dónde saldrá y con qué fuerza
{
    public Rigidbody bala;
    public Transform cañon;
    public float fuerzadisparo;

    // Se declara una variable para el número de municiones
    public float municion;



 
    // Se declara una interfaz de texto para ligar las municiones
    public Text municionText;

    //Se vincula la munición al texto que aparecerá en pantalla
    private void Start()
    {
        municionText.text = municion.ToString();
    }



    // Update is called once per frame
    void Update()
    //Se declara que al tocar el botó izquierdo del mouse, el proyectil saldrá dsiparado desde otro objeto aplicando el valor de fuerza establecido, logrando asi el disparo
    {
        municionText.text = municion.ToString();


        //Se condiciona que si la munición es mayor o igual a 1 entonces el arma disparará, esto servirá para que el arma tenga un "cargador"
        if (municion >= 1)
            {

          if (Input.GetMouseButtonDown(0))
          {
            Rigidbody balapos = Instantiate(bala, cañon.position, cañon.rotation) as Rigidbody;
            balapos.AddForce(cañon.forward * fuerzadisparo);
                //Se declara que, cada vez que se dispare, la munición disminuirá en una unidad
            municion -= 1; 
          }

        }

    }

    //En este punto se declara que al colisionar con los ítems de munición, ésta aumentará en 3 unidades
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Municion")
        {
            municion += 3;
        }

        if (collision.gameObject.tag == "Municion1")
        {
            municion += 3;
        }
    }

}