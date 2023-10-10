
using UnityEngine;

class Practice : MonoBehaviour
{
    [SerializeField] int bulletCount = 10;
    [SerializeField] int magazineCount = 5;
    [SerializeField] int magazineCapacity = 10;

    [SerializeField] KeyCode shootKey = KeyCode.Space;  // Melyik gombra lövünk
    [SerializeField] KeyCode reloadKey = KeyCode.R;  // Melyik gombra töltünk

    void Update()
    {


        bool shootkeyPress = Input.GetKeyDown(shootKey);
        bool reloadkeyPress = Input.GetKeyDown(reloadKey);

        if (shootkeyPress)
        {
            if (bulletCount > 0)
            {
                Debug.Log("Bumm");
                bulletCount--;
            }
            else
            {

                Debug.Log("Klikk");
            }
        }
        if (reloadkeyPress)
        {
            if (magazineCount > 0)
            {
                bulletCount = magazineCapacity;
                magazineCount--;
            }
        }
    }
}
