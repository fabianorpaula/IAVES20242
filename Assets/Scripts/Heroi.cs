using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Heroi : MonoBehaviour
{

    private NavMeshAgent agente;
    public GameObject Objetivo;
    public List<GameObject> Destinos;
    private Vector3 LocalDestinado;
    public int IndiceLocal = 0;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        IndiceLocal = Random.Range(0, Destinos.Count);
        LocalDestinado = Destinos[IndiceLocal].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        agente.SetDestination(LocalDestinado);

        if(Vector3.Distance(transform.position, LocalDestinado) < 5)
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
}
