using UnityEngine;

public class color_changer : MonoBehaviour
{
    public Rigidbody rb;
    public Material player;
    public Material goal1;
    public Material goal2;
    public Material goal3;
    public Material goal4;
    public Material goal5;
    public Material goal6;

    void Start()
    {
        player.color = Color.white;
    }
    void OnCollisionEnter(Collision p)
    {
        if (p.gameObject.name == "p1")
        {
            player.color = goal1.color;
        }
        if (p.gameObject.name == "p2")
        {
            player.color = goal2.color;
        }
        if (p.gameObject.name == "p3")
        {
            player.color = goal3.color;
        }
        if (p.gameObject.name == "p4")
        {
            player.color = goal4.color;
        }
        if (p.gameObject.name == "p5")
        {
            player.color = goal5.color;
        }
        if (p.gameObject.name == "p6")
        {
            player.color = goal6.color;
        }
    }

    void Update()
    {
        if (rb.position.y < -5)
        {
            player.color = Color.white;
        }
    }
}	

