using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class goustscript : MonoBehaviour
{

    public GameObject target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (target==null)
        {
            target = GameObject.FindGameObjectWithTag("Player");        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
