﻿using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    // How long our level is.
    public int maxPlatforms = 20;
    // The actual game object
    public GameObject platform;
    // Range of positions where we will spawn a new platform
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -6f;
    public float verticalMax = 6;

    // Where our initial offset is.
    private Vector2 originPosition;

    // Use this for initialization
    void Start()
    {
        originPosition = transform.position;
        Spawn();
    }

    // Function that generates a new gameobject.
    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }

}