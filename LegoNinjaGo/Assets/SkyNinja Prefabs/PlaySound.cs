using UnityEngine;

// The Audio Source component has an AudioClip option.  The audio
// played in this example comes from AudioClip and is called audioData.

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
       
        Debug.Log("started");
    }
    public void PlaySounds()
    {
        audioData.Play(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Kai")
        {
            PlaySounds();
        }

    }

}