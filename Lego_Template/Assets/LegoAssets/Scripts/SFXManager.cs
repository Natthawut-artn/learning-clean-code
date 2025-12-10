using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public List<AudioClip> SFXList = new List<AudioClip>();

    public void Play(GameObject gameObject , SFX sFX)
    {
        AudioClip clip = SFXList[(int)sFX];
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.playOnAwake = false;
        audioSource.loop = false;

        audioSource.Play();
        Destroy(audioSource, clip.length);
    }
}
