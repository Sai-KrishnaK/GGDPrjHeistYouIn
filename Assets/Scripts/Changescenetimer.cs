using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescenetimer : MonoBehaviour
{
    public float changetime;
    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        changetime -= Time.deltaTime;
        if(changetime<=0)
        {
            SceneManager.LoadScene(sceneName);
        }
        //SceneManager.LoadScene(sceneName);
    }
}
