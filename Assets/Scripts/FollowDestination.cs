using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowDestination : MonoBehaviour {

    public NavMeshAgent ThisAgent = null;
    public Transform Destination = null;

	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        ThisAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update () {
        ThisAgent.SetDestination(Destination.position);
	}
}
