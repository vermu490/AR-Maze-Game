using System.Collections;
using UnityEngine;

public class End : MonoBehaviour
{
	public GameObject winPanel;

	public GameObject winEffect;

	public float effectTime = 10f;

	private void OnTriggerEnter(Collider other)
	{
		Object.Destroy(other.gameObject);
		StartCoroutine(Win());
	}

	private IEnumerator Win()
	{
		base.gameObject.GetComponent<AudioSource>().Play();
		winPanel.SetActive(value: true);
		winEffect.SetActive(value: true);
		yield return new WaitForSeconds(effectTime);
		base.gameObject.GetComponent<AudioSource>().Stop();
		winPanel.SetActive(value: false);
		winEffect.SetActive(value: false);
	}
}
