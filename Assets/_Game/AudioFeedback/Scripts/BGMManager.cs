using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance = null;
    AudioSource bgmSource;
    [SerializeField] AudioClip musicClip = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            bgmSource = GetComponent<AudioSource>();
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        if (musicClip != null)
            Instance.PlaySong(musicClip);
    }

    private void PlaySong(AudioClip clip)
    {
        bgmSource.clip = clip;
        bgmSource.Play();
    }
}
