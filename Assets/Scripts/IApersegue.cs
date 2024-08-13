using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IApersegue : MonoBehaviour
{
    public GameObject Inimigo;
    private NavMeshAgent Agente;
    private Vector3 PosInicial;

    // Start is called before the first frame update
    void Start()
    {
        Agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, 
            Inimigo.transform.position);
        if(distancia < 10)
        {
            Agente.SetDestination(Inimigo.transform.position);
        }
        else
        {
            Agente.SetDestination(PosInicial);
        }

        
    }
}
