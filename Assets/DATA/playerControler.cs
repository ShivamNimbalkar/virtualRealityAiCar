using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class playerControler : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray= cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //move our agent
                agent.SetDestination(hit.point); 

            }
            
            


        }
    }
}
