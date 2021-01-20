using UnityEngine;


namespace GeekbrainsStudy
{
    class BuffComponent :
        MonoBehaviour,
        IBuff
    {
        public void Interact(PlayerController playerController)
        {
            playerController.Heal();
            Destroy(gameObject);
        }
    }
}
