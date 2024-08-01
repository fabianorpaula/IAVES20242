using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IaInteligente : MonoBehaviour
{

    public GameObject Inimigo;
    private NavMeshAgent Agente;

    // Start is called before the first frame update
    void Start()
    {
        Agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Agente.SetDestination(Inimigo.transform.position);
    }
}
