using UnityEngine;

class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) 
        : base(newName, newHp, newSuitColor)
    {
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
}