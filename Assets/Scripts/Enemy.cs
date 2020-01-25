/*
 * Jacob Buri
 * Enemy.cs
 * Assignment 1
 * Concrete class that uses the two interfaces and the abstract class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Combat, Damage, Dodge
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
			Debug.Log("Enemy hit");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Enemy missed");
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
			Debug.Log("Enemy hurt themselves in confusion");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Enemy snapped out of confusion");
		}
	}

	//Returns damage
	public override int GetDamage()
	{
		Debug.Log("Enemy Damage = " + damage);
		return damage;
	}

	//Returns evasion
	public int GetEvasion()
	{
		Debug.Log("Enemy Evasion = " + evasion);
		return evasion;
	}

	//Returns HP
	public override int GetHP()
	{
		Debug.Log("Enemy HP = " + hit_points);
		return hit_points;
	}

	//Returns name
	public string GetName()
	{
		Debug.Log("Enemy Name = " + thisName);
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
