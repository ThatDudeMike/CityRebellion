using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuildingSystem
{
    public class Building : MonoBehaviour
    {
        [SerializeField]
        private GameObject selectionPlane;

        private void Awake()
        {
            selectionPlane.SetActive(false);
        }




        private void OnMouseEnter()
        {
            selectionPlane.SetActive(true);
        }

        private void OnMouseExit()
        {
            selectionPlane.SetActive(false);
        }
    }
}
