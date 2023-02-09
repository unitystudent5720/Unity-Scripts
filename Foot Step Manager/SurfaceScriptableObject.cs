using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Surface", menuName = "ScriptableObjects/Surface")]
public class SurfaceScriptableObject : ScriptableObject
{
    public string tag;
    public List<AudioClip> stepAudioClips;
}