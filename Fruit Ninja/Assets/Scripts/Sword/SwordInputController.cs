using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordInputController : MonoBehaviour
{

    [SerializeField] private SwordDataTransmitter swordDataTransmitter;
    private bool dragging;
    public Vector2 swipeStart;


    void Update()
    {
        SetMouseTouch();
    }



    private void SetMouseTouch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
            swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


        else if (Input.GetMouseButtonUp(0) && dragging)
        {
            dragging = false;
            swordDataTransmitter.GetCutSpawner();

        }

    }
}
