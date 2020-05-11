using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private int clues = 0;
    private int artifacts = 0;
    private int truth = 0;

    public int updateClues(int change)
    {
        if ((clues += change) < 0)
            return -1;
        clues += change;
        return clues;
    }

    public int updateArtifacts(int change)
    {
        if ((artifacts += change) < 0)
            return -1;
        artifacts += change;
        return artifacts;
    }

    public int updateTruth(int change)
    {
        if ((truth += change) < 0)
            return -1;
        truth += change;
        return truth;
    }
}
