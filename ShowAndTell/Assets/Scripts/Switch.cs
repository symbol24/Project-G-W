using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public AudioSource audioSource;
    public Interaction interaction;
    public GameObject switchLeft;
    public GameObject switchRight;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            audioSource.Play();
            switchLeft.SetActive(false);
            switchRight.SetActive(true);
            interaction.Interact();
        }
    }
}
