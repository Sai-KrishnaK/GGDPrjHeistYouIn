using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.transform.tag == "Enemy") || (collision.transform.tag == "Enemy"))
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
        else if(collision.transform.tag == "Spawnable")
        {
            PlayerManager.isGamecomp = true;
            gameObject.SetActive(false);
        }

    }
}
