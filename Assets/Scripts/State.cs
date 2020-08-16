﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [SerializeField] int left;
    [SerializeField] int right;
    [SerializeField] int current;


    [TextArea(5, 15)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }

    public int GetCurrentIndex()
    {
        return current;
    }

    public int GetLeftIndex()
    {
        return left;
    }

    public int GetRightIndex()
    {
        return right;
    }

}