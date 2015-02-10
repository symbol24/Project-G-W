using UnityEngine;
using System.Collections;

public class Flag : MonoBehaviour
{

    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            audioSource.Play();
            Application.LoadLevel(0);
        }
    }
}
