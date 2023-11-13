using System.Collections;
using UnityEngine;

namespace Assets.scripts.Wall
{
    public class CollsisionWithCartridge : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            var cartidge=Utilities.GetCartridge(collision.gameObject);
            cartidge?.DestroyYourself();
        }
    }
}