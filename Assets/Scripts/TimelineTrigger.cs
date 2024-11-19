using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector;

    

    private void OnTriggerStay(Collider other)
    {
        playableDirector.Play();
    }
    
}
