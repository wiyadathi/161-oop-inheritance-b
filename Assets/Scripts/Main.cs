using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public IronMan IronMan;
    public CaptainAmerica CaptainAmerica;

    // Start is called before the first frame update
    void Start()
    {
        IronMan.Name = "";

        // Show Attributes
        Debug.Log($"IronMan name: {IronMan.Name}, HP: {IronMan.Hp}, color: {IronMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {CaptainAmerica.Name}, HP: {CaptainAmerica.Hp}, color: {CaptainAmerica.SuitColor}");

        IronMan.UpdateArmor(5.25f);
        CaptainAmerica.UpdateArmor(5.5f);
    }

    private void Update()
    {
        if (IronMan.IsDead() || CaptainAmerica.IsDead())
        {
            return;
        }

        // Iron Man turn
        int randomDamage = Random.Range(10, 21);
        IronMan.ShootLaser();
        CaptainAmerica.TakeDamege(randomDamage);

        // Captain America turn
        randomDamage = Random.Range(10, 21);
        CaptainAmerica.ThrowShield();
        IronMan.TakeDamege(randomDamage);
    }
}
