using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
// Play an intro Clip followed by a loop
public AudioSource introAudioSource;
public AudioSource loopAudioSource;

void Start () 
{

introAudioSource = GetComponent<AudioSource>();
loopAudioSource = GetComponent<AudioSource>();

double introDuration = (double)introAudioSource.clip.samples / introAudioSource.clip.frequency;
double startTime = AudioSettings.dspTime + 0.2;
introAudioSource.PlayScheduled(startTime);
loopAudioSource.PlayScheduled(startTime + introDuration);

    }
}
