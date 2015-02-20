using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour{

    public int sceneToLoad;

    public bool quitButton = false;

	public void Interact()
    {
        if (quitButton)
        {
            Debug.Log("Quit");
            //UnityEditor.EditorApplication.isPlaying = false;
			Application.Quit();
        }
        else
        {
            Application.LoadLevel(sceneToLoad);
        }
    }
}
