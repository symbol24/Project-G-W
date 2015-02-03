using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour {

    public List<GameObject> linkedInteractions;
	public bool linked = false;
    public GameObject online;
    public GameObject offline;
	
	public void Awake()
	{
		//linkedInteractions = new List<GameObject>();
	}
	
    public void Interact()
    {
        //Activate or Deactivate the object
        Switch();
        Debug.Log("Interaction");
    }

    private void Switch()
    {
        if(linked && linkedInteractions.Count > 0)
        {
            PutOnline();
            for(int i = 0; i < linkedInteractions.Count; i++)
            {
                linkedInteractions[i].GetComponent<Interaction>().PutOffline();
            }
        }
        else
        {
            online.SetActive(!online.activeInHierarchy);
            offline.SetActive(!offline.activeInHierarchy);
        }
    }

    public void PutOnline()
    {
        online.SetActive(true);
        offline.SetActive(false);
    }

    public void PutOffline()
    {
        online.SetActive(false);
        offline.SetActive(true);
    }

}
