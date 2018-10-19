namespace VRTK.Examples
{
    using UnityEngine;

    public class GunShoot : MonoBehaviour
    {
        public VRTK_InteractableObject linkedObject;
        public GameObject projectile;
        public Transform projectileSpawnPoint;
        public float projectileSpeed = 1000f;
        public float projectileLife = 5f;

        protected virtual void OnEnable()
        {
            linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed += InteractableObjectUsed;
            }
        }

        protected virtual void OnDisable()
        {
            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
            }
        }

        protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
            FireProjectile();
        }

        protected virtual void FireProjectile()
        {
            Debug.Log("AAAA");
        }
    }
}