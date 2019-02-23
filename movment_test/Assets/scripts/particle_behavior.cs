using UnityEngine;

public class particle_behavior : MonoBehaviour {

    public ParticleSystem p1;
    public ParticleSystem p2;
    public ParticleSystem p3;
    public ParticleSystem p4;
    public ParticleSystem p5;
    public ParticleSystem p6;

    void OnCollisionEnter(Collision col)
    {
        var em1 = p1.emission;
        var em2 = p2.emission;
        var em3 = p3.emission;
        var em4 = p4.emission;
        var em5 = p5.emission;
        var em6 = p6.emission;

        if (col.gameObject.name == "Ground")
        {
            em1.enabled = false;
            em2.enabled = false;
            em3.enabled = false;
            em4.enabled = false;
            em5.enabled = false;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p1")
        {
            em1.enabled = true;
            em2.enabled = false;
            em3.enabled = false;
            em4.enabled = false;
            em5.enabled = false;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p2")
        {
            em1.enabled = false;
            em2.enabled = true;
            em3.enabled = false;
            em4.enabled = false;
            em5.enabled = false;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p3")
        {
            em1.enabled = false;
            em2.enabled = false;
            em3.enabled = true;
            em4.enabled = false;
            em5.enabled = false;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p4")
        {
            em1.enabled = false;
            em2.enabled = false;
            em3.enabled = false;
            em4.enabled = true;
            em5.enabled = false;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p5")
        {
            em1.enabled = false;
            em2.enabled = false;
            em3.enabled = false;
            em4.enabled = false;
            em5.enabled = true;
            em6.enabled = false;
        }
        if (col.gameObject.name == "p6")
        {
            em1.enabled = false;
            em2.enabled = false;
            em3.enabled = false;
            em4.enabled = false;
            em5.enabled = false;
            em6.enabled = true;
        }
    }
}
