using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehavior : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;
    public LineRenderer lineOfsight;

    void Start()
    {
        Physics2D.queriesStartInColliders = false;
        
    }

   
    void Update()
    { 
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if(hitInfo.collider != null){
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfsight.SetPosition(1, hitInfo.point);

            if(hitInfo.collider.CompareTag("Player")){
                Destroy(hitInfo.collider.gameObject);
            }
            
        }
        else {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
            lineOfsight.SetPosition(1, transform.position + transform.right * distance);
        }
        
        lineOfsight.SetPosition(0, transform.position);
    }
}
