using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    private int strength = 10;
    private int speed = 10;
    private int dexterity = 10;
    private int toughness = 10;
    private int precision = 10;

    public int getStrength() { return strength; }
    public int getSpeed() { return speed; }
    public int getDexterity() { return dexterity; }
    public int getToughness() { return toughness; }
    public int getPrecision() { return precision; }
}
