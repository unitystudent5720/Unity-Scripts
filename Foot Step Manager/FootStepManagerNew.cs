using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepManagerNew : MonoBehaviour
{
    public List<AudioClip> defaultSteps = new List<AudioClip>();
    public List<ScriptableObject> surfaces = new List<ScriptableObject>();
    private List<AudioClip> currentList = new List<AudioClip>();
    private AudioSource source;
    private Dictionary<string, List<AudioClip>> surfaceDictionary = new Dictionary<string, List<AudioClip>>();

    void Start()
    {
        source = GetComponent<AudioSource>();
        currentList = defaultSteps;
        // convert to dictionary for effectancy
        foreach (SurfaceScriptableObject surface in surfaces)
        {
            surfaceDictionary.Add(surface.tag, surface.stepAudioClips);
        }
    }
    public void PlayStep()
    {
        AudioClip clip = currentList[Random.Range(0, currentList.Count)];
        source.PlayOneShot(clip);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (surfaceDictionary.ContainsKey(hit.transform.tag))
        {
            currentList = surfaceDictionary[hit.transform.tag];
        } else
        {
            currentList = defaultSteps;
        }
    }
    

}
