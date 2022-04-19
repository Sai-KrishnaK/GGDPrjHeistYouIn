using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollhandler : MonoBehaviour
{

    public GameObject[] scrolls;
    private int artifactcount;

    // Start is called before the first frame update
    void Start()
    {
        artifactcount = GameObject.FindGameObjectsWithTag("artifact").Length; 
    }

    public void scrollsAcheived()
    {
        int artifactleft = GameObject.FindGameObjectsWithTag("artifact").Length;
        int artifactcollected = artifactcount - artifactleft;

        float percentage = float.Parse(artifactcollected.ToString()) / float.Parse(artifactcount.ToString()) * 100f;

        if(percentage >= 20f && percentage < 30)
        {
            scrolls[0].SetActive(true);
        }
        else if(percentage >= 30 && percentage < 50)
        {
            scrolls[0].SetActive(true);
            scrolls[1].SetActive(true);
        }
        else
        {
            scrolls[0].SetActive(true);
            //scrolls[1].SetActive(true);
            //scrolls[2].SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
