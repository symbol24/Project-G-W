using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flag : MonoBehaviour
{
	
	
	public GameObject m_TheBoard;
	public Text m_theResultText1;
	public Text m_theResultText2;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
			audioSource.Play();
			deathManager dm = collider.gameObject.GetComponent<deathManager>() as deathManager;
			EndLevel(dm.m_deathCounter);
			dm.DebugStats();
			Destroy(collider.gameObject);
        }
    }

	public void EndLevel(int deathCount){
		m_TheBoard.SetActive (true);
		m_theResultText1.gameObject.SetActive (true);
		m_theResultText2.text = deathCount + " Times!";
		m_theResultText2.gameObject.SetActive (true);
	}
}
