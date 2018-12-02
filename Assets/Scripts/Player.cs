using UnityEngine;

[System.Serializable]
public class Player
{
    public string name = "Player";
    public int level = 1;
    public int health = 100;
    public float[] position = new float[3];

    public Player()
    {

    }

    public Player(string name, int level, int health, Vector3 position)
    {
        this.name = name;
        this.level = level;
        this.health = health;
        this.position = new float[3] { position.x, position.y, position.z };
    }
}
