using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject fireBallPrefab;
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private GameObject LaserBallPrefab;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform robTransform;
    [SerializeField] private Transform shotPoint;
    public void CreaterMisslie()
    {
        Instantiate(missilePrefab, shotPoint.position, shotPoint.rotation);

    }//複製或創造的一個gameobject
    public void CreaterFireBall()
    {
        Instantiate(fireBallPrefab, shotPoint.position, shotPoint.rotation);
    }
    public void CreaterLaserBall()
    {
        Instantiate(LaserBallPrefab, shotPoint.position, shotPoint.rotation);
    }
}
