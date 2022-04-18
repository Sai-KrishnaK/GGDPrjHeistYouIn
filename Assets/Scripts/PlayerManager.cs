using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isGamecomp;
    public GameObject SuccessScreen;
    public GameObject gameoverscreen;
    private void Awake()
    {
        isGameOver = false;
        isGamecomp = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameoverscreen.SetActive(true);
        }
        else if(isGamecomp)
        {
            SuccessScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
