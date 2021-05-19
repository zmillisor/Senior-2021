using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public Transform ground;
    public Transform teachersDesk;
    public Transform player;

    public Transform floor1;
    public Transform floor2;

    public void GoingUP()
    {
        ground.position = floor2.position;
        teachersDesk.position = floor2.position;
        player.position = floor2.position;

        player.transform.Translate(Vector3.up * 1.2f);

        ElevatorHover.canUp = false;

        ElevatorHover.canDown = true;
    }

    public void GoingDown()
    {
        ground.position = floor1.position;
        teachersDesk.position = floor1.position;
        player.position = floor1.position;

        player.transform.Translate(Vector3.up * 1.2f);

        ElevatorHover.canUp = true;

        ElevatorHover.canDown = false;
    }
}
