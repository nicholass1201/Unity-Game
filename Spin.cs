using UnityEngine;

public class Spin : MonoBehaviour
{
   public float rotationSpeed = 45; 
   private static int activeSpinCount = 2; // Keeps track of active Spin objects
   public static bool timerStarted = false; // Flag to track timer state
   private float elapsedTime = 0;
   public Timer timer;

   public void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.CompareTag("Player")) 
      {
         gameObject.SetActive(false); 
         activeSpinCount--; // Decrease count on deactivation
         if (activeSpinCount == 1 && !timerStarted) 
         {
            timer.StartTimer();
            timerStarted=true;
         }
         if (activeSpinCount == 0 && timerStarted)
         {
            timer.StopTimer();
            timerStarted=false;
         }
      }
   }


   private void ResetTimer()
   {
      timer.resetTimer();
      activeSpinCount = 2;
      timerStarted = false;
   }

   void Update()
   {
      transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
      if (Input.GetMouseButtonDown(0))
      {
         ResetTimer();
      }
      if (timerStarted)
      {
         //elapsedTime += Time.deltaTime; // Increment elapsed time
      }
      if (!timerStarted)
         elapsedTime = 0;
   }
}

