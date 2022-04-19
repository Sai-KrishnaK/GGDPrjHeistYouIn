using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linetestesting : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private linecontroller line;
    // Start is called before the first frame update
    private void Start()
    {
        line.Setupline(points);
    }

    
}
