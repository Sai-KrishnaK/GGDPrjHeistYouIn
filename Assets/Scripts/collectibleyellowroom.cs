using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleyellowroom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerManager.numofcollectibles++;
            PlayerPrefs.SetInt("numofcollectibles", PlayerManager.numofcollectibles);
            Destroy(gameObject);
        }
    }
}
