using UnityEngine;

class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor)
    {
    }

    public void LeapAndJump()
    {
        Debug.Log($"\t {name}: is LeapAndJump");
    }

    public void ThrowShield()
    {
        Debug.Log($"\t {name}: is ThrowShield");
    }
}
