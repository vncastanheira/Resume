using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerSnapshot : MonoBehaviour {

    public AudioMixerSnapshot mixer;

    private void Start()
    {
        mixer.TransitionTo(0);
    }
}
