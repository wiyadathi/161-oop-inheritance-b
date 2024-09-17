using UnityEngine;

public class IronMan : SuperHero
{
    // Behaviour
    public void Fly()
    {
        Debug.Log($"\t {_name}: is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"\t {_name}: is Shooting laser");
    }
}