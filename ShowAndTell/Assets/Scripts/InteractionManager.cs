using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractionManager : MonoBehaviour {

    List<GameObject> interactions;
    public GameObject pointer;
    int cursor;

    void Start()
    {
        cursor = 0;
        interactions = new List<GameObject>();
        interactions.AddRange(GameObject.FindGameObjectsWithTag("Interaction"));
        MovePointer();
    }

    void Update()
    {
        if(Control.getKeyDownLeft())
        {
            MoveCursor(-1);
            MovePointer();
        }
        if(Control.getKeyDownRight())
        {
            MoveCursor(+1);
            MovePointer();
        }
        if(Control.getKeyDownSpace())
        {
            interactions[cursor].GetComponent<Interaction>().Interact();
        }
    }

    void MoveCursor(int offset)
    {
        cursor += offset;
        while (cursor < 0) cursor += interactions.Count;
        cursor = cursor % interactions.Count;
    }

    void MovePointer()
    {
        pointer.transform.position = new Vector3(interactions[cursor].transform.position.x,
                                                 interactions[cursor].transform.position.y + 1,
                                                 interactions[cursor].transform.position.z);
    }
}
