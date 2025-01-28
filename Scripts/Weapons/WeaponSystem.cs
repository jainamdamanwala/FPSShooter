using UnityEngine;
using Photon.Pun;

public class WeaponSystem : MonoBehaviourPunCallbacks
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.2f;
    public int maxAmmo = 30;
    public float reloadTime = 2f;

    private int currentAmmo;
    private bool isReloading = false;
    private float nextTimeToFire = 0f;

    void Start()
    {
        currentAmmo = maxAmmo;
    }

    void Update()
    {
        if (!photonView.IsMine) return;

        if (isReloading) return;

        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire && currentAmmo > 0)
        {
            nextTimeToFire = Time.time + fireRate;
            Shoot();
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    void Shoot()
    {
        currentAmmo--;
        PhotonNetwork.Instantiate(bulletPrefab.name, firePoint.position, firePoint.rotation);
    }

    System.Collections.IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}
