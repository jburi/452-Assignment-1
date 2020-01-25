/*
 * Jacob Buri
 * Combat.cs
 * Assignment 1
 * Abstract class for hp and damage numbers
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gives object hp and damage to fight
public abstract class Combat
{
	public abstract void SetHP(int newHP);
	public abstract int GetHP();
	public abstract void SetDamage(int damage);
	public abstract int GetDamage();
}
