using UnityEngine;

class IronMan
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float _armorStrenght;

    // Constructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        _armorStrenght = 10;
    }

    // Behaviour
    public void Fly()
    {
        Debug.Log($"\t {Name}: is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"\t {Name}: is Shooting laser");
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