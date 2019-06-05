﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    private void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }
}
