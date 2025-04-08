/******************************************************************************
* Created by: Smilelifer
* Date: 2025-04-08 21:32:13
* Des: 
*******************************************************************************/

using System.Collections.Generic;
using NBC.ActionEditor;
using NBC.ActionEditorExample;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

[Name("GE")]
[Description("GE")]
[Color(70f / 255f, 1, 140f / 255f)]
[Attachable(typeof(TestCustomGASTrack))]
public class TestReleaseGEClip : ActionClip
{
    [SerializeField] [HideInInspector] private float length = 1f;
    
    [MenuName("Gameplay Effects")]
    public GameplayEffect[] gameplayEffect;
    public List<GameplayEffect> gameplayEffects2;
    
    [OdinSerialize][ShowInInlineEditors]
    public GameplayTag[] gameplayTags;
    public List<GameplayTag> gameplayTags2;
    
    public GameplayCue[] gameplayCues;
    public List<GameplayCue> gameplayCues2;

    public int testInt;
    public override float Length
    {
        get => length;
        set => length = value;
    }

    public override string info => $"缩放 释放ge";

    public override bool isValid => true;

    private ActionTrack Track => (ActionTrack)Parent;

    public override string ToString()
    {
        return "TestReleaseGEClip" + base.ToString() + " " + gameplayEffect.Length + " " + gameplayTags.Length + " " + gameplayCues.Length;
    }
}