using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycamera : MonoBehaviour
{
    public float rotspeed;
    public float distance;
    public LineRenderer lineofsight;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotspeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineofsight.SetPosition(1, hitInfo.point);

            if (hitInfo.collider.CompareTag("Player"))
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.blue);
            lineofsight.SetPosition(1, transform.position + transform.right * distance);
        }
        lineofsight.SetPosition(0, transform.position);
    }

}
