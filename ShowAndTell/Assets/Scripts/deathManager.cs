using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deathManager : MonoBehaviour {
	
	public Vector3 m_origPosition = new Vector3(0,0,0);
	public Text m_theText;
	public int m_deathCounter = 0;
	public int m_jumpCounter = 0;
	public int[,] m_stats = new int[1,2];

	public void DeathCount()
	{
		m_deathCounter++;
		m_stats [0, 0] = m_deathCounter;
		UpdateText ();
		transform.position = m_origPosition;
	}

	public void JumpCount(){
		m_jumpCounter++;
		m_stats [0,1] = m_jumpCounter;
	}

	public void UpdateText(){
		m_theText.text = m_deathCounter.ToString();
	}

	public void DebugStats(){
		for(int i = 0; i < m_stats.GetLength(0); i++){
			for(int y = 0; y < m_stats.GetLength(1); y++){
				if(m_stats[i,y] > 10){
					print ("stat higher than " + m_stats[i,y]);
				}
			}
		}
	}
}
