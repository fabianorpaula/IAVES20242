using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaBurra : MonoBehaviour
{

    public GameObject Inimigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }


    void Mover()
    {

        transform.position = Vector3.MoveTowards(transform.position, Inimigo.transform.position, 0.01f);

    }
}
