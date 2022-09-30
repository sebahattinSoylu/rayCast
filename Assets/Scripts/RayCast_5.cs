using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RayCast_5 : MonoBehaviour
{
    [SerializeField] private Material degisecekMat;
    [SerializeField] private Material defaultMat;

    private Transform secilenNesne;

    private void Update()
    {
        if (secilenNesne != null)
        {
            var secilenRenderer = secilenNesne.GetComponent<Renderer>();
            secilenRenderer.material = defaultMat;
            secilenNesne = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag("secilebilir"))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer)
                {
                    defaultMat = selectionRenderer.material;
                    selectionRenderer.material = degisecekMat;
                }

                secilenNesne = selection;
            }
        }
    }
}
