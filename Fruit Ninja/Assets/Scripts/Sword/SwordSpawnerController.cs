using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSpawnerController : MonoBehaviour
{

    [SerializeField] private SwordDataTransmitter swordDataTransmitter;
    public GameObject cutPrefab;
    public float cutLifeTime;
    private Vector2 swipeEnd;


    public void SetCutSpawner()
    {
        swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject cutInstance = Instantiate(cutPrefab, swipeEnd, Quaternion.identity);
        cutInstance.GetComponent<LineRenderer>().SetPosition(0, swordDataTransmitter.GetSwipeStart());
        cutInstance.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);
        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0] = Vector2.zero;
        colliderPoints[1] = swipeEnd - swordDataTransmitter.GetSwipeStart();
        cutInstance.GetComponent<EdgeCollider2D>().points = colliderPoints;
        Destroy(cutInstance, cutLifeTime);
    }

}
