using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected int _hp;
    public abstract void Damage(int atk);
}