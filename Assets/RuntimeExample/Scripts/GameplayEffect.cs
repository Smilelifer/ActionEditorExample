/******************************************************************************
* Created by: Smilelifer
* Date: 2025-04-08 21:29:27
* Des: 
*******************************************************************************/

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gameplay Effect", menuName = "Gameplay Effect")]
public class GameplayEffect : ScriptableObject
{
    public List<GameplayTag> assetTags;
    public float duration;
    public List<GameplayCue> cueOnActivation;
    public List<GameplayCue> cueOnDeactivation;
}