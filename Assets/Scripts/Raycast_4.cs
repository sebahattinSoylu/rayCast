using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_4 : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        float maxUzaklik = 10f;
        RaycastHit hit;

        bool carptimi = Physics.SphereCast(transform.position, transform.lossyScale.x/2,transform.right,out hit,maxUzaklik);

        if (carptimi)
        {
            Gizmos.color=Color.green;
            //Gizmos.DrawRay(transform.position,transform.forward*hit.distance);
            //Gizmos.DrawWireCube(transform.position+transform.forward*hit.distance,transform.lossyScale);
            Gizmos.DrawWireSphere(transform.position+transform.right*hit.distance,transform.lossyScale.x/2);
        }
        else
        {

            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position,transform.forward*maxUzaklik);
            //Gizmos.DrawWireCube(transform.position,transform.forward*maxUzaklik);
        }
    }
}
