using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    private void Awake() 
    {
        setDexterity(10);
        setPrecision(10);
        setSpeed(10);
        setToughness(10);
        setStrength(10);
    }
}
