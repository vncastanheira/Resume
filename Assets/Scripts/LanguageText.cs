using UnityEngine;
using UnityEngine.UI;

public class LanguageText : MonoBehaviour
{
    public LanguageTextOption Option;

    private void Start()
    {
        var textComp = GetComponent<Text>();
        switch (Option)
        {
            case LanguageTextOption.Start:
                textComp.text = LanguageManager.Instance.language.Start;
                break;
            case LanguageTextOption.Credits:
                textComp.text = LanguageManager.Instance.language.Credits;
                break;
            case LanguageTextOption.Loading:
                textComp.text = LanguageManager.Instance.language.Loading;
                break;
            case LanguageTextOption.Options:
                textComp.text = LanguageManager.Instance.language.Options;
                break;
            default:
                break;
        }
    }

}

public enum LanguageTextOption
{
    Start,
    Credits,
    Loading,
    Options
}
