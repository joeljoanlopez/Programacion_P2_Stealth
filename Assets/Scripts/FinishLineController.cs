using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb = collision.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            SceneManager.LoadScene("Ending");
            print("Hehe");
        }
    }
}
