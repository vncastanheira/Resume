﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    public Text rendererText;

    public float Delay = 3;
    float timer;

    int index = 0;
    string currentLine;
    StringReader sReader;

    string resume;

    void Start()
    {
        resume = LanguageManager.Instance.language.Resume.text;
        sReader = new StringReader(resume);

        timer = 1;
        StartCoroutine(Write());
    }
    

    IEnumerator Write()
    {
        yield return new WaitForSeconds(1);
        currentLine = sReader.ReadLine();
        while (currentLine != null)
        {
            rendererText.text = "";
            foreach (var c in currentLine)
            {
                rendererText.text += c;
                yield return new WaitForSeconds(0.08f);
            }
            yield return new WaitForSeconds(Delay);
            timer = Delay;
            currentLine = sReader.ReadLine();
        }
    }
}
