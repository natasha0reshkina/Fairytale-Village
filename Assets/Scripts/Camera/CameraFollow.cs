using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      
    public Vector3 offset;           
    public float smoothSpeed = 0.125f;  

    public float windowWidth = 2f;  
    public float windowHeight = 2f; 

    void LateUpdate()
    {

        Vector3 targetPosition = target.position + offset;
        
       
        Vector3 diff = targetPosition - transform.position;
        
        float moveX = 0f;
        float moveY = 0f;

    
        if (Mathf.Abs(diff.x) > windowWidth / 2)
        {
     
            moveX = diff.x - Mathf.Sign(diff.x) * (windowWidth / 2);
        }
        
      
        if (Mathf.Abs(diff.y) > windowHeight / 2)
        {
           
            moveY = diff.y - Mathf.Sign(diff.y) * (windowHeight / 2);
        }
        
      
        Vector3 desiredPosition = transform.position + new Vector3(moveX, moveY, 0f);
        
        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}