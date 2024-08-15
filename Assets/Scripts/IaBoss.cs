using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaBoss : MonoBehaviour
{
    public enum Estado { Parado, Magica, Porrada};
    public Estado MeuEstado;
    private Animator anim;
    private GameObject Heroi;
    public float distancia;

    void Start()
    {
        anim = GetComponent<Animator>();
        MeuEstado = Estado.Parado;
        Heroi = GameObject.FindGameObjectWithTag("Player");
    }



    void Update()
    {
        distancia = Vector3.Distance(transform.position,
            Heroi.transform.position);


        if(distancia > 20 ) {
            MeuEstado = Estado.Parado;
        }
        else if (distancia > 10)
        {
            MeuEstado = Estado.Magica;
        }
        else
        {
            MeuEstado = Estado.Porrada;
        }


        if(MeuEstado == Estado.Parado)
        {
            anim.SetBool("Parado", true);
        }

        if (MeuEstado == Estado.Magica)
        {
            anim.SetBool("Parado", false);
            anim.SetBool("Perto", false);
            transform.LookAt(Heroi.transform.position);
        }

        if (MeuEstado == Estado.Porrada)
        {
            anim.SetBool("Parado", false);
            anim.SetBool("Perto", true);
            transform.LookAt(Heroi.transform.position);
        }


    }
}
