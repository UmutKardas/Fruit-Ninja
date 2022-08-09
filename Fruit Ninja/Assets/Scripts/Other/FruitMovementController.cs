using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMovementController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D fruitRigidbody2D;
    [SerializeField] private float limitX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float lifeTime;


    void Start()
    {
        SetFruitMovement();
    }



    private void SetFruitMovement()
    {
        fruitRigidbody2D.velocity = new Vector2(Random.Range(-limitX, limitX), Random.Range(minY, maxY));
        Destroy(gameObject, lifeTime);
    }
}
