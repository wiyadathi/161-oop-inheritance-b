using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    protected string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";
            }

            _name = value;
        }
    }

    protected int hp;
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }

    public string SuitColor { get; protected set; }

    private float armorStrenght;

    public void UpdateArmor(float newArmor)
    {
        armorStrenght += newArmor;
        Debug.Log($"\t {_name} update armor to {armorStrenght}");
    }

    public void TakeDamege(int inputDamage)
    {
        hp -= inputDamage;
        Debug.Log($"\t{_name} take damege({inputDamage}) => {_name} HP:{hp}");

        if (IsDead())
        {
            Debug.Log($"\t{_name} is DEAD..");
        }
    }

    public bool IsDead()
    {
        return (hp <= 0);
    }
}