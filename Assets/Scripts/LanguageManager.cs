using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public static LanguageManager Instance
    {
        get
        {
            var manager = FindObjectOfType<LanguageManager>();
            if (manager == null)
            {
                Debug.LogError("Language Manager not found in the Hierarchy.");
                Debug.Break();
            }
            return manager;
        }
    }

    [HideInInspector]
    public Language language;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetLanguage(Language asset)
    {
        language = asset;
    }

}
