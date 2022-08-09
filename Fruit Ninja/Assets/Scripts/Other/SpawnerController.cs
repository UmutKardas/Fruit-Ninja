using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    [SerializeField] private GameObject prefabObject;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float limitX;
    [SerializeField] private float startTime;
    private float time;


    void Update()
    {
        SetTimeSpawn();
    }



    private void SetTimeSpawn()
    {
        if (time <= 0)
        {
            SetspawnObject();
            time = startTime;
        }


        else
        {
            time -= Time.deltaTime;
        }
    }



    private void SetspawnObject()
    {
        GameObject newPrefab = Instantiate(prefabObject);
        newPrefab.transform.position = new Vector2(Random.Range(-limitX, limitX), transform.position.y);
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }

}
