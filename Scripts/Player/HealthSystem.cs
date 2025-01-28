using UnityEngine;
using Photon.Pun;

public class HealthSystem : MonoBehaviourPunCallbacks
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    [PunRPC]
    public void TakeDamage(int damage)
    {
        if (!photonView.IsMine) return;

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died");
        PhotonNetwork.Destroy(gameObject);
    }
}
