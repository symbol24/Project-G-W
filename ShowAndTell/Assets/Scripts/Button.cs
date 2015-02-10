using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public KeyCode keyCode;
    public GameObject buttonUp;
    public GameObject buttonDown;

	void Update () {
        if (Input.GetKey(keyCode))
        {
            buttonUp.SetActive(false);
            buttonDown.SetActive(true);
        }
        else
        {
            buttonUp.SetActive(true);
            buttonDown.SetActive(false);
        }
	}
}
