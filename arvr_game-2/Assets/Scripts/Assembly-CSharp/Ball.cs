using UnityEngine;

public class Ball : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (((double)base.gameObject.GetComponent<Rigidbody>().velocity.x > 0.01 || (double)base.gameObject.GetComponent<Rigidbody>().velocity.y > 0.01) && !base.gameObject.GetComponent<AudioSource>().isPlaying)
		{
			base.gameObject.GetComponent<AudioSource>().Play();
		}
		else if (base.gameObject.GetComponent<AudioSource>().isPlaying)
		{
			base.gameObject.GetComponent<AudioSource>().Pause();
		}
	}
}
