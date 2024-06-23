using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverclip;
    [SerializeField] private AudioClip magiceMissileClip;
    [SerializeField] private AudioClip takeDamageClip;
    [SerializeField] private AudioClip LaserBallClip;
    [SerializeField] private AudioClip FireBallClip;

    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverclip);
    }

    public void PlayMagicMissileLaunch()
    {
        audioSource.PlayOneShot(magiceMissileClip);
    }
    public void PlayTakeDamage()
    {
        audioSource.PlayOneShot(takeDamageClip);
    }
    public void playLaserBallLaunch()
    {
        audioSource.PlayOneShot(LaserBallClip);
    }
    public void playFireBallLaunch()
    {
        audioSource.PlayOneShot(FireBallClip);
    }
    
}
