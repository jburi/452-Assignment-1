/*
 * Jacob Buri
 * Boss.cs
 * Assignment 1
 * Concrete class to improve the player's damage
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Increased damage for the player
public class Weapon
{
	public string thisName = "";
	public int damageIncrease = 0;

	public void SetDamage(int damage)
	{
		damageIncrease = damage;
	}
	
	public void SetName(string Name)
	{
		thisName = Name;
	}
	public int GetDamage()
	{
		return damageIncrease;
	}

	public string GetName()
	{
		return thisName;
	}
}
