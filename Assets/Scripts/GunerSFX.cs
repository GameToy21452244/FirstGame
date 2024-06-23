using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunerSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip ShotFireSound;

    public void PlayShotFireSFX()
    {
        audioSource.PlayOneShot(ShotFireSound);
    }
}
