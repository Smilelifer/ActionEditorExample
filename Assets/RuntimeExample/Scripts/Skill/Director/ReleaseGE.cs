/******************************************************************************
* Created by: Smilelifer
* Date: 2025-04-09 00:03:36
* Des: 
*******************************************************************************/

using NBC.ActionEditorExample;
using UnityEngine;

public class ReleaseGETask  : SkillClipBase
{
    private TestReleaseGEClip releaseGEClipTrack => ActionClip as TestReleaseGEClip;
    
    protected override void Begin()
    {
       Debug.Log("ReleaseGE Begin releaseGEClipTrack info " + releaseGEClipTrack.ToString()); 
    }

    protected override void Tick()
    {
        base.Tick();
        //Debug.Log("ReleaseGE Tick releaseGEClipTrack info " + releaseGEClipTrack.ToString()); 
    }

    protected override void End()
    {
        Debug.Log("ReleaseGE End releaseGEClipTrack info " + releaseGEClipTrack.ToString());
        
    }
}
