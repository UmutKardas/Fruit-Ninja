using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordTriggerController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Bomb"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
