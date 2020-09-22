using UnityEngine;

public abstract class Ennemi : MonoBehaviour, Damageable
{
    int lifeTotal = 1;
    protected SoundPlayer soundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        soundPlayer = GameObject.FindGameObjectWithTag("SoundPlayer").GetComponent<SoundPlayer>();
        EnnemiStart();
    }

    public abstract void EnnemiStart();

    public abstract void Die();

    public void TakeDamage(int damage)
    {
        lifeTotal -= damage;

        if (lifeTotal <= 0)
        {
            Die();
        }
    }
}
