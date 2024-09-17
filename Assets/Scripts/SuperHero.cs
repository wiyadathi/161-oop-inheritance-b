using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float _armorStrenght;

    // Constructor
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        _armorStrenght = 10;
    }

    public void UpdateArmor(float newArmor)
    {
        _armorStrenght += newArmor;
        Debug.Log($"\t {Name} update armor to {_armorStrenght}");
    }

    public void TakeDamege(int inputDamage)
    {
        Hp -= inputDamage;
        Debug.Log($"\t{Name} take damege({inputDamage}) => {Name} HP:{Hp}");

        if (IsDead())
        {
            Debug.Log($"\t{Name} is DEAD..");
        }
    }

    public bool IsDead()
    {
        return (Hp <= 0);
    }
}