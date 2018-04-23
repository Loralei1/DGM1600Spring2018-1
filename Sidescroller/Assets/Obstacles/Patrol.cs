using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour {

	public Transform[] PatrolPoints;
	private int destPoint = 0;
	public NavMeshAgent agent;


	// Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent> ();
		agent.autoBraking = false;
		GoToNextPoint ();
		
	}

	void GoToNextPoint ()
	{
		agent.destination = PatrolPoints[destPoint].position;
		destPoint = (destPoint + 1) % PatrolPoints.Length;
	}
	// Update is called once per frame
	void Update () 
	{
		if (!agent.pathPending && agent.remainingDistance < 0.5f) 
		{
			GoToNextPoint();
		}
		
	}
}
