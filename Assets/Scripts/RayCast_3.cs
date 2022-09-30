using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_3 : MonoBehaviour
{
    public LayerMask maskeLayer;

    private void OnDrawGizmos()
    {
        float maxUzaklik = 10f;
        RaycastHit hit;

        bool carptimi = Physics.BoxCast(transform.position, transform.lossyScale,transform.forward,out hit,transform.rotation,maxUzaklik);

        if (carptimi)
        {
            Gizmos.color=Color.green;
            Gizmos.DrawRay(transform.position,transform.forward*hit.distance);
            Gizmos.DrawWireCube(transform.position+transform.forward*hit.distance,transform.lossyScale);
        }
        else
        {

            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position,transform.forward*maxUzaklik);
            //Gizmos.DrawWireCube(transform.position,transform.forward*maxUzaklik);
        }
    }
}
