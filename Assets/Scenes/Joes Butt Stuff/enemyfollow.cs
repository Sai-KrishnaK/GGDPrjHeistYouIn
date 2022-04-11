using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollow : MonoBehaviour
{

    public float speed;
    public float stopingDistance;
    public float retreatDistance;
    public Transform player;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;


        
        
    }

 
    // Update is called once per frame
    void Update() {

        if(Vector2.Distance(transform.position, player.position) > stopingDistance){
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if(Vector2.Distance(transform.position, player.position)< stopingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance){
            transform.position= this.transform.position; 
        } else if(Vector2.Distance(transform.position, player.position) < retreatDistance){
transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
            
        


    }
    }
