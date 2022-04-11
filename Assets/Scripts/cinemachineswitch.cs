
using System.Collections;
using System.Collections.Generic;
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

  //  public Animator animator;

    private bool overworldCamera = true;

   

    private void SwitchPriority()
    {
        if(overworldCamera)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
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


    // Start is called before the first frame update
    void Start()
    {
        action.performed += _ => SwitchPriority();
    }

   
}
