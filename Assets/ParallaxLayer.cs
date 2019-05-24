using UnityEngine;

public class ParallaxLayer : MonoBehaviour {
   public float fraction;
   
   void UpdatePosition() {
      var camPos = Camera.main.transform.position;
      var pos = new Vector3(camPos.x * fraction, camPos.y * fraction, transform.position.z);
      transform.position = pos;
   }

   private void OnDrawGizmos() {
       UpdatePosition();
   }
}
