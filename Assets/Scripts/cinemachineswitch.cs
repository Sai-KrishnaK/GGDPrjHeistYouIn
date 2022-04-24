

using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class cinemachineswitch : MonoBehaviour
{

    [SerializeField]
    private InputAction action;

    [SerializeField]
    private CinemachineVirtualCamera vcam1; // pverworld

    [SerializeField]
    private CinemachineVirtualCamera vcam2; // player

    
    public float duration;
    private bool currentTime = false;

   



    //  public Animator animator;

    private bool overworldCamera = true;

     void Update()
    {
        if((currentTime == true)&&(duration < 3))
        {
            duration += Time.deltaTime;
            
        }
        else if ((currentTime == true) && (duration >= 3))
        {
            duration = 0;
            currentTime = false;
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
    }


    private void SwitchPriority()
    {
        if(overworldCamera)
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
            currentTime = true;
Update();
          
        }   
        
        else
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        overworldCamera = !overworldCamera;
    }

    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();   
    }

    //private void Update()
    //{
    //    if((overworldCamera == true) && (duration < 3))
    //    {
    //        duration += Time.deltaTime;
    //    }
    //    else if (duration > 3)
    //    {
    //        duration = 0;
    //        action.performed += _ => SwitchPriority();
    //    }
    //}


    // Start is called before the first frame update
    void Start()
    {
        action.performed += _ => SwitchPriority();
    }

   
}
