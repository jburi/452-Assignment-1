/*
 * Jacob Buri
 * CombatSimulator.cs
 * Assignment 1
 * Tests classes using methods and lists
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSimulator : MonoBehaviour
{
	public Player sora;
	public Boss sephiroth;
	public Weapon keyBlade;
	public Boss[] multiBoss = new Boss[3];
	public List<Boss> bossList = new List<Boss>();
	public List<Combat> combatList = new List<Combat>();
	public List<Damage> dealSomeDamage = new List<Damage>();
	public Enemy heartless;

    // Start is called before the first frame update
    void Start()
    {
		/*----------PART-1----------*/

		//Create Objects
		sora = new Player();
		sephiroth = new Boss();
		keyBlade = new Weapon();
		heartless = new Enemy();

		//Weapon Setup
		keyBlade.SetName("Key Blade");
		keyBlade.SetDamage(5);

		//Test weapon before equiping
		keyBlade.GetName();
		keyBlade.GetDamage();

		//Player Setup
		sora.SetName("Sora");
		sora.SetHeight(55.50);
		sora.SetEvasion(4);
		sora.SetDamage(5);
		sora.SetHP(50);

		//Player Info Test
		sora.GetName();
		sora.GetHeight();
		sora.GetEvasion();
		sora.GetDamage();
		sora.GetHP();

		//Boss Setup
		sephiroth.SetName("Sephiroth");
		sephiroth.SetEvasion(3);
		sephiroth.SetDamage(5);
		sephiroth.SetHP(100);

		//Boss Info Test
		sephiroth.GetName();
		sephiroth.GetEvasion();
		sephiroth.GetDamage();
		sephiroth.GetHP();

		//Weapon equip
		sora.EquipWeapon(keyBlade);
		sora.GetDamage();

		/*-----FIGHT-----*/
		Debug.Log("Fighting Starts");

		//Sora deals 5 player damage + 5 weapon damage if hit is landed
		sora.DealtDamage(sephiroth);
		sephiroth.GetHP();

		//Sephiroth deals 5 damage if hit is landed
		sephiroth.DealtDamage(sora);
		sora.GetHP();

		//Test again (twice) incase evaded
		sora.DealtDamage(sephiroth);
		sephiroth.GetHP();
		sephiroth.DealtDamage(sora);
		sora.GetHP();
		sora.DealtDamage(sephiroth);
		sephiroth.GetHP();
		sephiroth.DealtDamage(sora);
		sora.GetHP();


		/*----------PART-2----------*/
		Debug.Log("Multi-Boss Array");
		//Declare vars
		int counter = 5;
		multiBoss[0] = new Boss();
		multiBoss[1] = new Boss();
		multiBoss[2] = new Boss();

		//index out of bounds
		//multiBoss[3] = new Boss();
		//Set and get boss hp from a list
		foreach (Boss boss in multiBoss)
		{
			if(boss == null) { break; }

			boss.SetHP(counter);
			boss.GetHP();
			counter = counter + counter;
		}

		/*----------PART-3----------*/
		Debug.Log("Boss List");
		//Add 6 bosses to the list
		for (int i = 0; i < 3; i++)
		{
			bossList.Add(new Boss());
			bossList.Add(new Boss());
		}

		//Test Index out of bounds
		bossList.Add(new Boss());

		//Remove Boss at index position 6
		bossList.RemoveAt(6);

		//Remove the 3 enemies at positions 3-5
		bossList.RemoveRange(3, 3);

		foreach (Boss boss in bossList)
		{
			if (boss == null) { break; }

			boss.SetHP(counter);
			boss.GetHP();
			counter = counter + counter;
		}

		/*----------PART-4----------*/
		Debug.Log("Combat List");
		//Add counter to differentiate damage
		int counter2 = 2;

		//Add 6 combat ready fighters
		for (int i = 0; i < 2; i++)
		{
			dealSomeDamage.Add(new Boss());
			dealSomeDamage.Add(new Player());
		}

		foreach (Combat fighter in dealSomeDamage)
		{
			if (fighter == null) { break; }
			fighter.SetDamage(counter2);
			fighter.GetDamage();
			counter2 = counter2 * counter2;
		}
	}

	// Update is called once per frame
	void Update()
	{
		/*----------PART-5----------*/
		//Add counter to differentiate damage
		int counter2 = 2;

		//If 1 is pressed on the keyboard, an abstract method will be called
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log("Pressed 1");
			//Add 6 combat ready fighters
			for (int i = 0; i < 2; i++)
			{
				combatList.Add(new Boss());
				combatList.Add(new Player());
			}

			foreach (Combat fighter in combatList)
			{
				if (fighter == null) { break; }
				fighter.SetHP(counter2);
				fighter.GetHP();
				counter2 = counter2 * counter2;
			}
		}

		/*----------PART-6----------*/
		//Part 5 with interfaces		
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log("Pressed 2");
			//Add 6 combat ready fighters
			for (int i = 0; i < 2; i++)
			{
				dealSomeDamage.Add(new Player());
			}

			foreach (Damage fighter in dealSomeDamage)
			{
				if (fighter == null || sephiroth.GetHP() == 0) { break; }
				fighter.DealtDamage(sephiroth);
			}
		}

		/*----------PART-7----------*/
		//Added Enemy as another concrete class		
		if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log("Pressed 1 & 2");
			//Enemy Setup
			heartless.SetName("Heartless");
			heartless.SetEvasion(3);
			heartless.SetDamage(5);
			heartless.SetHP(100);

			//Enemy Info Test
			heartless.GetName();
			heartless.GetEvasion();
			heartless.GetDamage();
			heartless.GetHP();
		}
	}
}
