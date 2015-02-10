using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public float cooldown = 2;
    private float timer;
    public Transform prefab;

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= cooldown)
        {
            Instantiate(prefab);
            timer = 0;
        }
	}
}
