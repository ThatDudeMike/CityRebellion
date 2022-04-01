using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoldierSystem;

public class PlayerController : MonoBehaviour
{
    private Squad selectedSquad = null;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<Squad>())
                {
                    Squad squad = hit.collider.gameObject.GetComponent<Squad>();
                    if (squad)
                    {
                        SelectSquad(squad);
                    }
                }
                else
                {
                    SelectSquad(null);
                }
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            if (selectedSquad)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    selectedSquad.SetSquadDestination(hit.point);
                }
            }
        }
    }
    private void SelectSquad(Squad newSquad)
    {
        if(selectedSquad)
        {
            selectedSquad.SelectSquad(false);
        }
        
        selectedSquad = newSquad;
        if (selectedSquad)
        {
            selectedSquad.SelectSquad(true);
        }     
    }
}
