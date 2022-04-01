using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SoldierSystem
{
    public class Squad : MonoBehaviour
    {
        private NavMeshAgent agent;

        private List<Soldier> soldiers = new List<Soldier>();

        private bool bIsSelected = false;
        [SerializeField]
        private GameObject selectionPlane;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            if(!agent)
            {
                throw new System.Exception("Nav Mesh Agent couldn't be found on the squad.");
            }

            soldiers = new List<Soldier>(GetComponentsInChildren<Soldier>());
            if(soldiers.Count <= 0)
            {
                throw new System.Exception("No soldiers could be found for the squad.");
            }

            selectionPlane.SetActive(false);
        }

        private void Update()
        {
            if(agent.hasPath)
            {
                SquadIsMoving(true);
            }
            else
            {
                SquadIsMoving(false);
            }
        }

        private void SquadIsMoving(bool moving)
        {
            foreach(Soldier sol in soldiers)
            {
                sol.SetMoving(moving);
            }
        }

        public void SelectSquad(bool selected)
        {
            bIsSelected = selected;
            selectionPlane.SetActive(selected);
        }

        public void SetSquadDestination(Vector3 dest)
        {
            agent.SetDestination(dest);
        }
    }
}
