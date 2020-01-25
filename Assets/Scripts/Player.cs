/*
 * Jacob Buri
 * Player.cs
 * Assignment 1
 * One of the concrete classes from the combat abstract
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Combat, Damage, Dodge
{
	string thisName = "";
	double height = 0;
	int hit_points = 0;
	int evasion = 0;
	int damage = 0;
	Weapon weapon = new Weapon();

	//Reduce boss hp
	public void DealtDamage(Boss target)
	{
		//Uses a Random number to randomize hits to evasion
		System.Random rnd = new System.Random();
		int evasionCheck = rnd.Next(0, 6);
		if (evasionCheck < target.GetEvasion())
		{
			Debug.Log("Player hit");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Player missed");
		}
	}
	//Self inflicted damage
	public void DealtDamage(Player target)
	{
		//Uses a Random number to randomize hits to evasion
		System.Random rnd = new System.Random();
		int evasionCheck = rnd.Next(0, 6);
		if (evasionCheck < target.GetEvasion())
		{
			Debug.Log("Player hurt themselves in confusion");
			int hp = target.GetHP();
			target.SetHP(hp - damage);
		}
		else
		{
			Debug.Log("Player snapped out of confusion");
		}
	}

	//Equips selected weapon and applies damage increase
	public void EquipWeapon(Weapon newWeapon)
	{
		weapon = newWeapon;
		int weaponDamage = newWeapon.GetDamage();
		damage = damage + weaponDamage;
	}

	//Returns damage
	public override int GetDamage()
	{
		Debug.Log("Player Damage = " + damage);
		return damage;
	}

	//Returns evasion
	public int GetEvasion()
	{
		Debug.Log("Player Evasion = " + evasion);
		return evasion;
	}

	//Returns height
	public double GetHeight()
	{
		Debug.Log("Player Height = " + height);
		return height;
	}

	//Returns name
	public string GetName()
	{
		Debug.Log("Player Name = " + thisName);
		return thisName;
	}

	//Returns HP
	public override int GetHP()
	{
		Debug.Log("Player HP = " + hit_points);
		return hit_points;
	}

	//Returns equiped weapon
	public Weapon GetWeapon()
	{
		Debug.Log("Player Weapon = " + weapon.ToString());
		return weapon;
	}
	
	//Sets base damage
	public override void SetDamage(int newDamage)
	{
		damage = newDamage;
	}

	//Sets evasion to dodge
	public void SetEvasion(int newEvasion)
	{
		evasion = newEvasion;
	}

	//Sets height
	public void SetHeight(double newHeight)
	{
		height = newHeight;
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
