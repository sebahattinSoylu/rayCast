using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_1 : MonoBehaviour
{
    public LayerMask maske;
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100,maske,QueryTriggerInteraction.Ignore))
        {
            Debug.DrawLine(ray.origin,hit.point,Color.green);
            //print(hit.collider.name);
           // Destroy(hit.transform.gameObject);
        }
        else
        {
            Debug.DrawLine(ray.origin,ray.origin+ray.direction*100,Color.red);
            
        }

    }
}
