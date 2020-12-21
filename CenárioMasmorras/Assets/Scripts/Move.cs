using UnityEngine;
using System.Collections;

//Classe move.
public class Move : MonoBehaviour
{

    float _velocidadeFrente;
    float _velocidadeTras;
    float _velocidadeGirar;

    //Metodo Start e executado uma unica vez, quando o script e executado.
    void Start()
    {
        _velocidadeFrente = 6f;
        _velocidadeTras = 5f;
        _velocidadeGirar = 200f;
    }

    //Medodo Update e executado a cada Frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
        }
    }
}

