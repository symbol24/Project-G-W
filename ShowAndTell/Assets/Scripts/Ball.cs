using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }
}
