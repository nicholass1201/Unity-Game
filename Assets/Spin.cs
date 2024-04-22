using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
   public float rotationSpeed = 45;
   private static int activeSpinCount = 2; // Keeps track of active Spin objects
   private static bool timerStarted = false; // Flag to track timer state
   private float elapsedTime = 0;

   public void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.CompareTag("Player"))
      {
         gameObject.SetActive(false);
         activeSpinCount--; // Decrease count on deactivation
         if (activeSpinCount == 1 && !timerStarted)
         {
            StartTimer();
         }
         if (activeSpinCount == 0 && timerStarted)
         {
            EndTimer();
         }
      }
   }

   private void StartTimer()
   {
      timerStarted = true;
      elapsedTime = 0; // Reset elapsed time
   }

   private void EndTimer()
   {
      timerStarted = false;
      int hours = (int)(elapsedTime / 3600);
      int minutes = (int)((elapsedTime % 3600) / 60);
      int seconds = (int)(elapsedTime % 60);

      // Format the time as a string
      string formattedTime = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

      // Update the Text component with the formatted time
      Debug.Log("Timer Ended. Elapsed Time: " + formattedTime);
   }

   private void ResetTimer()
   {
      elapsedTime = 0;
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
         elapsedTime += Time.deltaTime; // Increment elapsed time
      }
      if (!timerStarted)
         elapsedTime = 0;
   }

}