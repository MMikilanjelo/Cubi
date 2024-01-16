using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject _platformPrefab;

    public float _platformSpawnHeight = 0f;
    public float _platformSpawnInterval = 2f;

    public float _platformDestroyDelay = 3f;

    public void Start ()
    {
        StartCoroutine(GeneratePlatforms());
    }
    IEnumerator GeneratePlatforms()
    {
        while (true)
        {
           //Add spawn logick here
        }
    }

}
