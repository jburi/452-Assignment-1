/*
 * Jacob Buri
 * Interfaces.cs
 * Assignment 1
 * Interfaces for Player.cs and Boss.cs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows damage to objects
public interface Damage
{
	void DealtDamage(Player target);
	void DealtDamage(Boss target);
}

//Allows dodging using evasion
public interface Dodge
{
	int GetEvasion();
	void SetEvasion(int newEvasion);
}
