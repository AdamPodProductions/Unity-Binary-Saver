using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public InputField nameText;
    public InputField levelText;
    public InputField healthText;

    public InputField xText;
    public InputField yText;
    public InputField zText;

    private Player player = new Player();

    public void Save()
    {
        string name = nameText.text;
        int level = int.Parse(levelText.text);
        int health = int.Parse(healthText.text);
        Vector3 position = new Vector3(float.Parse(xText.text), float.Parse(yText.text), float.Parse(zText.text));

        player = new Player(name, level, health, position);
        UnityBinarySaver.Save(player, "player.ubs");
    }

    public void Load()
    {
        player = UnityBinarySaver.Load<Player>("player.ubs");

        nameText.text = player.name;
        levelText.text = player.level.ToString();
        healthText.text = player.health.ToString();

        xText.text = player.position[0].ToString();
        yText.text = player.position[1].ToString();
        zText.text = player.position[2].ToString();
    }
}
