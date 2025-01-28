using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    public GameObject[] weapons;
    private int currentWeaponIndex = 0;

    void Start()
    {
        SelectWeapon(currentWeaponIndex);
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Length;
            SelectWeapon(currentWeaponIndex);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            currentWeaponIndex = (currentWeaponIndex - 1 + weapons.Length) % weapons.Length;
            SelectWeapon(currentWeaponIndex);
        }
    }

    void SelectWeapon(int index)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(i == index);
        }
    }
}
