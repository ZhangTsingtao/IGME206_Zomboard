using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public Vector3 raycastPosition;
    // Update is called once per frame
    void Update()
    {
        

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            //look
            Vector3 lookPoint = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(lookPoint);
            raycastPosition = hit.point;
        }
    }

    
}
