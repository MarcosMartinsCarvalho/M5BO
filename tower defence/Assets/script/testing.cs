using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    private Vector3 targetPosition;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
         
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; 

            
            targetPosition = mousePosition;
        }

        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5f);
    }
}
