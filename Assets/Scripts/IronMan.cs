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
        Debug.Log($"\t {name}: is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"\t {name}: is Shooting laser");
    }
}