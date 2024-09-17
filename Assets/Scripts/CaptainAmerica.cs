using UnityEngine;

class CaptainAmerica
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float _armorStrenght;

    // Constructor
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        _armorStrenght = 10;
    }

    public void LeapAndJump()
    {
        Debug.Log($"\t {Name}: is LeapAndJump");
    }

    public void ThrowShield()
    {
        Debug.Log($"\t {Name}: is ThrowShield");
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

    // If HP less then 0 or equal 0, mean true
    public bool IsDead()
    {
        return (Hp <= 0);
    }
}
