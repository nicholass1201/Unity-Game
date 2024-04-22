using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectiveProgression : MonoBehaviour
{
    public Slider progressionSlider;
    public Text notificationText;
    public FirstPersonController playerController;
    public Score scoreScript;

    private float[] scoreThresholds = {500, 1000, 1500, 2000};  // Thresholds for each upgrade
    private string[] upgradeNames = {"Sprint Speed Upgrade", "Double Jump", "Wall Jump", "Unlimited Stamina"}; // Names of upgrades
    private int currentUpgradeIndex = 0; // Index to track which upgrade is next

    void Update()
    {
        UpdateProgressionBar();

        //if current score meets the threshold
        if (currentUpgradeIndex < scoreThresholds.Length && scoreScript.GetCumulativeScore() >= scoreThresholds[currentUpgradeIndex])
        {
            UnlockUpgrade(currentUpgradeIndex);
            currentUpgradeIndex++;
        }
    }

    private void UpdateProgressionBar()
    {
        //Update the slider based on current score and the next threshhold
        if (currentUpgradeIndex < scoreThresholds.Length)
        {
            progressionSlider.value = scoreScript.GetCumulativeScore() / scoreThresholds[currentUpgradeIndex];
        }
    }

    private void UnlockUpgrade(int index)
    {
        // switch case for the update, if these are set to true, playercontroller script is updated
        switch (index)
        {
            case 0:  // Sprint Speed Upgrade
                playerController.hasSprintUpgrade = true;
                break;
            case 1:  // Double Jump
                playerController.hasDoubleJumpUpgrade = true;
                break;
            case 2:  // Wall Jump
                playerController.hasWallJumpUpgrade = true;
                break;
            case 3:  // Unlimited Stamina
                playerController.hasUnlimitedStamina = true;
                break;
        }
        //UI stuff idk if this works tbh
        notificationText.text = "Unlocked: " + upgradeNames[index] + "!";
        notificationText.gameObject.SetActive(true);
        StartCoroutine(HideNotification());
    }
    IEnumerator HideNotification()
    {
        yield return new WaitForSeconds(5); // Display the notification for 5 seconds
        notificationText.gameObject.SetActive(false);
    }

}
