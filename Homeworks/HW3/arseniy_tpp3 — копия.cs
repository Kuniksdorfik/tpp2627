using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

abstract class Character
{
    private string name;
    private int hp;
    private int power;

    public static int count = 0;

    public string Name 
    {
        get {return name;}      //можно использоваьб =>, но мне привычней get
    }
  public int Hp
    {
        get {return hp;}
    }
    public int Power
    {
        get {return power;}
    }

    public Character(string name, int power, int hp)
    {
        if (!IsValidStats(hp, power))
        {
            throw new ArgumentException("incorrect values");
        }
        
        this.name = name;
        this.power = power;
        this.hp = hp;
        count+1;
    }
    public static int HowMany()
    {
        return count;
    }

    public static bool IsValidStats(int hp, int power)
    {
        return hp > 0 && power > 0;
    }

    public void TakeDamage(int damage)
    {
        return hp -= damage;
    }

    public bool IsAlive()
    {
        return hp > 0;
    }

    public GetStatus(string name, int hp)
    {
        return(Console.WriteLine("${name}: {hp}"));
    }
}

class Player : Character
{
    
}

class Enemy : Character
{
    
}

//до 4ого пункта
