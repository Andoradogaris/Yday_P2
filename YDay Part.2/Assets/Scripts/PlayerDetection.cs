using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, player.transform.position * 2, Color.red);

        if(Physics.Raycast(transform.position, player.transform.position, out hit, 2))
        {
            Debug.Log("Le Raycast touche un objet !");
        }
    } 
}
