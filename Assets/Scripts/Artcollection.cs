using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artcollection : MonoBehaviour
{

    private float art = 0;
    public int numberToSpawn;
    public List<GameObject> Escapeloc;
    public GameObject Endroom;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Art")
        {
            spawnobject();
            Destroy(other.gameObject);
           
        }
    }

    
   public void spawnobject()
    {
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = Endroom.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, Escapeloc.Count);
            toSpawn = Escapeloc[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }
}
