using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isGamecomp;
    public GameObject SuccessScreen;
    public GameObject gameoverscreen;
    // public Text levelstatus;
    public TextMeshProUGUI scrollText;

    public static int numofcollectibles;

    private void Awake()
    {
        numofcollectibles = PlayerPrefs.GetInt("numofcollectibles", 0);
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
        scrollText.text = numofcollectibles.ToString();
        if(isGameOver)
        {
            gameoverscreen.SetActive(true);
        }
        else if(isGamecomp)
        {
            GetComponent<scrollhandler>().scrollsAcheived();
            SuccessScreen.SetActive(true);
            
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
