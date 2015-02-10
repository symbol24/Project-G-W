using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour
{

    public AudioSource audioSource;
    List<GameObject> menus;
    public GameObject pointer;
    int cursor;

    void Start()
    {
        cursor = 0;
        menus = new List<GameObject>();
        menus.AddRange(GameObject.FindGameObjectsWithTag("Menu"));
        MovePointer();
    }

    void Update()
    {
        if (Control.getKeyDownLeft())
        {
            MoveCursor(-1);
            MovePointer();
            audioSource.Play();
        }
        if (Control.getKeyDownRight())
        {
            MoveCursor(+1);
            MovePointer();
            audioSource.Play();
        }
        if (Control.getKeyDownSpace())
        {
            menus[cursor].GetComponent<Menu>().Interact();
            audioSource.Play();
        }
    }

    void MoveCursor(int offset)
    {
        cursor += offset;
        while (cursor < 0) cursor += menus.Count;
        cursor = cursor % menus.Count;
    }

    void MovePointer()
    {
        pointer.transform.position = new Vector3(menus[cursor].transform.position.x,
                                                 menus[cursor].transform.position.y + 1,
                                                 menus[cursor].transform.position.z);
    }
}
