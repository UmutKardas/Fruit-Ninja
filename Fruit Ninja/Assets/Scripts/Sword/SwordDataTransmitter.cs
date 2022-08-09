using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDataTransmitter : MonoBehaviour
{
    [SerializeField] private SwordInputController swordInputController;
    [SerializeField] private SwordSpawnerController swordSpawnerController;


    public Vector2 GetSwipeStart()
    {
        return swordInputController.swipeStart;
    }



    public void GetCutSpawner()
    {
        swordSpawnerController.SetCutSpawner();
    }
}
