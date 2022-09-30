using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_2 : MonoBehaviour
{
    public LayerMask maskeLayer;

    private void OnDrawGizmos()
    {
        float maxUzaklik = 10f;
        RaycastHit hit;

        bool carptimi = Physics.Raycast(transform.position, transform.forward, out hit, maxUzaklik, maskeLayer);

        if (carptimi)
        {
            Gizmos.color=Color.green;
            Gizmos.DrawRay(transform.position,transform.forward*hit.distance);
        }
        else
        {

            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position,transform.forward*maxUzaklik);
        }
    }
}
