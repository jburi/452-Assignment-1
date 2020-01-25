/*
 * Jacob Buri
 * Boss.cs
 * Assignment 1
 * One of the concrete classes from the combat abstract
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Combat, Damage, Dodge
{
	string thisName;
	int hit_points;
	int evasion;
	int damage = 0;

	//Damage Player
	public void DealtDamage(Player target)
	{
		//Uses a Random number to randomize hits to evasion
		System.Random rnd = new System.Random();
		int evasionCheck = rnd.Next(0, 6);
		if (evasionCheck < target.GetEvasion())
		{
			Debug.Log("Boss hit");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Boss missed");
		}
	}
	//Self inflicted damage
	public void DealtDamage(Boss target)
	{
		//Uses a Random number to randomize hits to evasion
		System.Random rnd = new System.Random();
		int evasionCheck = rnd.Next(0, 6);
		if (evasionCheck < target.GetEvasion())
		{
			Debug.Log("Boss hurt themselves in confusion");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Boss snapped out of confusion");
		}
	}

	//Returns damage
	public override int GetDamage()
	{
		Debug.Log("Boss Damage = " + damage);
		return damage;
	}

	//Returns evasion
	public int GetEvasion()
	{
		Debug.Log("Boss Evasion = " + evasion);
		return evasion;
	}

	//Returns HP
	public override int GetHP()
	{
		Debug.Log("Boss HP = " + hit_points);
		return hit_points;
	}

	//Returns name
	public string GetName()
	{
		Debug.Log("Boss Name = " + thisName);
		return thisName;
	}

	//Sets damage
	public override void SetDamage(int newDamage)
	{
		damage = newDamage;
	}

	//Sets evasion to dodge
	public void SetEvasion(int newEvasion)
	{
		evasion = newEvasion;
	}

	//Sets HP
	public override void SetHP(int newHP)
	{
		hit_points = newHP;
	}

	//Sets name
	public void SetName(string newName)
	{
		thisName = newName;
	}
}
    
