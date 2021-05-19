using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorHover : MonoBehaviour
{

    public GameObject goUp;
    public GameObject goDown;

    public bool canGoUp;
    public bool canGoDown;

    public static bool canUp;
    public static bool canDown;

    private void Start()
    {
        goUp.SetActive(false);
        goDown.SetActive(false);

        canUp = canGoUp;
        canDown = canGoDown;
    }

    private void Update()
    {
        canGoUp = canUp;
        canGoDown = canDown;
    }

    public void HoverStart()
    {
        if(canGoUp && canGoDown)
        {
            goUp.SetActive(true);
            goDown.SetActive(true);
        }
        else if (canGoUp && !canGoDown)
        {
            goUp.SetActive(true);
            goDown.SetActive(false);
        }
        else if (!canGoUp && canGoDown)
        {
            goUp.SetActive(false);
            goDown.SetActive(true);
        }
    }

    public void HoverExit()
    {
        goUp.SetActive(false);
        goDown.SetActive(false);
    }
}
