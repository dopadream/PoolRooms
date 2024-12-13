using UnityEngine;

namespace PoolRooms
{
    public class PoolLightBehaviour : MonoBehaviour
    {
        public Light LightToUpdate = null;

        public Color RedAlertColor = Color.red;

        public void OnApparatusPulled()
        {
            LightToUpdate.color = RedAlertColor;
        }
    }
}
