/******************************************************************************
* Created by: Smilelifer
* Date: 2025-04-08 21:27:15
* Des: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameplayTag
{
    public string tagName;
    public string tagDescription;
    public int tagID;
    public int tagFatherID;
}

[CreateAssetMenu(fileName = "New Gameplay Cue", menuName = "Gameplay Cue")]
public class GameplayCue :ScriptableObject
{
    public List<int> eventIDs;
    public List<GameplayTag> tags;
}
