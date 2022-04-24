using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleyellowroom : MonoBehaviour
{

    public float rotz;
    public float rotspeed;
    public bool clockwiserot;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerManager.numofcollectibles++;
            PlayerPrefs.SetInt("numofcollectibles", PlayerManager.numofcollectibles);
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    void Update()
    {
        if (clockwiserot == false)
        {
            rotz += Time.deltaTime * rotspeed;
        }
        else
        {
            rotz += -Time.deltaTime * rotspeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotz);

    }

}
