using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{

    public NavMeshAgent nav;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget(target.transform);
    }


    void MoveToTarget(Transform newTarget)
    {
        nav.destination = newTarget.position;
    }

        
}
