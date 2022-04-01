using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoldierSystem
{
    public class Soldier : MonoBehaviour
    {
        private bool bIsMoving = false;
        private bool bIsAlive = true;
        public bool IsAlive { get { return bIsAlive; } }
        private bool bIsShooting = false;

        private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            if(!animator)
            {
                throw new System.Exception("Could not find soldier animator");
            }
        }

        public void SetMoving(bool isMoving) 
        { 
            bIsMoving = isMoving;
            animator.SetBool("Moving", bIsMoving);
        }
        public void Die()
        {
            bIsAlive = false;
        }
        public void Shoot(bool shot)
        {
            bIsShooting = shot;
            animator.SetBool("Shooting", bIsShooting);
        }
    }
}
