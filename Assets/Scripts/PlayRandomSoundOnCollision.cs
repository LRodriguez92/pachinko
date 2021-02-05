using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSoundOnCollision : MonoBehaviour
{
    public List<AudioClip> possibleSounds;
    private AudioSource audioSource;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
   {
        if (possibleSounds.Count == 0)
        {
            Debug.LogWarning("Hey! You forgot to add your sounds!");
        }
        PlayRandomSound();
   }

    private void PlayRandomSound()
    {
        int randomSoundIndex = Random.Range(0, possibleSounds.Count);

        AudioClip soundToPlay = possibleSounds[randomSoundIndex];

        audioSource.PlayOneShot(soundToPlay);
    }
}
