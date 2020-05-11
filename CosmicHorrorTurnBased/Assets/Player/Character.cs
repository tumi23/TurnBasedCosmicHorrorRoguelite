using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected int strength;
    protected int speed;
    protected int dexterity;
    protected int toughness;
    protected int precision;

    public void setStrength(int newStrength) { strength = newStrength; }
    public void setSpeed(int newSpeed) { speed = newSpeed; }
    public void setDexterity(int newDexterity) { dexterity = newDexterity; }
    public void setToughness(int newToughness) { toughness = newToughness; }
    public void setPrecision(int newPrecision) { precision = newPrecision; }

    public int getStrength() { return strength; }
    public int getSpeed() { return speed; }
    public int getDexterity() { return dexterity; }
    public int getToughness() { return toughness; }
    public int getPrecision() { return precision; }
}
