using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{

    public Transform[] waypoints;
    public NavMeshAgent agent;

    public enum state{patroling,Attack};
    public state current;

    public bool reachedposition;

    public int random;
    // Start is called before the first frame update
    void Start()
    {
        FindNewLocation();
        current = state.patroling;
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(current){
            case state.patroling :
            if(agent.remainingDistance <= 0.5){
               reachedposition = true;
                FindNewLocation();
            }

            break;

            case state.Attack:
                if(reachedposition){
                    FindNewLocation();
                    reachedposition = false;
                }
            break;
        }
    }

    public void FindNewLocation(){
        random = Random.Range(0,3);

        switch(random){
            case 0:
            agent.SetDestination(waypoints[0].transform.position);
            agent.destination = waypoints[0].transform.position;
            break;

            case 1:
            agent.SetDestination(waypoints[1].transform.position);

            break;

            case 2:
            agent.SetDestination(waypoints[2].transform.position);
            break;

            case 3:
            agent.SetDestination(waypoints[3].transform.position);
            break;

            
        }

    }

    public void AttackAnim(){
        //here is wehre we will call attack animation

    }
}