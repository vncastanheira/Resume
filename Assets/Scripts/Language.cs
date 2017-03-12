using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Language", menuName = "Resume/Language")]
public class Language : ScriptableObject
{
    public string Start;
    public string Credits;
    public string Loading;
    public string Options;
    public TextAsset Resume;
}
