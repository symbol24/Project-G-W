using UnityEngine;
using System.Collections;

public class WindAnimation : MonoBehaviour {

	public GameObject[] sp_wind;
	int id = 0;
	public float SetTimer;
	float timer;

	// Update is called once per frame
	void Update () 
	{
		timer ++;

		if (timer == SetTimer)
		{
			id = (id+1) % sp_wind.Length;
			WindMove();
		}
	}

	void WindMove()
	{

		for (int i = 0; i < sp_wind.Length; i++)
		{
			if (sp_wind[i] == sp_wind[id])
			{
				sp_wind[i].renderer.enabled = true;
			}else{
				sp_wind[i].renderer.enabled = false;
			}
		}
		timer = 0f;
	}
}
