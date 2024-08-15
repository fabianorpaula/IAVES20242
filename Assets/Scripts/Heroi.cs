using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Heroi : MonoBehaviour
{

    private NavMeshAgent agente;
    private Animator anima;
    public GameObject Objetivo;
    public List<GameObject> Destinos;
    private Vector3 LocalDestinado;
    public int IndiceLocal = 0;

    public GameObject Inimigo;

    public string status = "Ronda";

    public GameObject Ataque;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        agente = GetComponent<NavMeshAgent>();
        IndiceLocal = Random.Range(0, Destinos.Count);
        LocalDestinado = Destinos[IndiceLocal].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (status == "Ronda")
        {
            anima.SetBool("Atacando", false);

            agente.SetDestination(LocalDestinado);

            if (Vector3.Distance(transform.position, LocalDestinado) < 5)
            {
                //Em Ordem
                /*IndiceLocal++;


                if(IndiceLocal >= Destinos.Count)
                {
                    IndiceLocal = 0;
                }*/

                IndiceLocal = Random.Range(0, Destinos.Count);
                LocalDestinado = Destinos[IndiceLocal].transform.position;
            }
        }

        if(status == "Ataque")
        {

            if (Inimigo == null)
            {
                status = "Ronda";
            }
            else
            {
                anima.SetBool("Atacando", true);
                agente.SetDestination(Inimigo.transform.position);
                transform.LookAt(Inimigo.transform.position);
            }
            
            
            

        }

    }

    public void Atacar_ligado()
    {
        Ataque.SetActive(true);
    }

    public void Atacar_desligado()
    {
        Ataque.SetActive(false);
    }

    private void OnTriggerEnter(Collider toque)
    {
        if (toque.gameObject.tag == "Inimigo")
        {
            Debug.Log("UI Me tocaram");
            status = "Ataque";
            Inimigo = toque.gameObject;
        }
    }
}
