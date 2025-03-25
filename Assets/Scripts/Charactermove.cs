using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermove : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidbody; // Se mantiene el nombre "rigidbody"
    private bool mirandoDerecha = true;

    private void Start() // Se corrige la mayúscula en "Start"
    {
        rigidbody = GetComponent<Rigidbody2D>(); // Se usa correctamente la variable
    }

    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);
        GestionarOrientacion(inputMovimiento);
    } 

    void GestionarOrientacion(float inputMovimiento)
    {
        //si se cumple condicion
        if( (mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {

          // ejecutar codigo volteado
          mirandoDerecha = !mirandoDerecha;
          transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }
}