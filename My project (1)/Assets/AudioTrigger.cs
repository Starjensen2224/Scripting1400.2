using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
private void OnTriggerEnter(Collider other)
    {
        audioSource.Play(); // Play the attached sound effect
    }
}
