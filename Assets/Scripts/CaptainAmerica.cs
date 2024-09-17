using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"\t {_name}: is LeapAndJump");
    }

    public void ThrowShield()
    {
        Debug.Log($"\t {_name}: is ThrowShield");
    }
}
