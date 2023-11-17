using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Text.Json;

public class AntiModding : MonoBehavior
{
    public bool isInitialized; // Simplifier Bool
    public string newJsonFilePath = "null"; // JSON path
    public string gameFilesPath = "null"; // GameFiles Path
    public int runTime = 0; // runtime Data;

    void Start ()
    {
        DateTime WriteDateTimer = DateTime.Now; // gets the current date
        Debug.log(WriteDateTimer); // logs the date to console
        if(runTime == 0) // checks how many times the script has ran
        {
            var dataObject = new // this is what is going inside of the Json File
            {
                writeDateTime = WriteDateTimer,
                openCount = runTime,
            }
            isInitialized = true; // sets a simpler method for runTime
            string jsonStringWrite = JsonSerializer.SerializeObject(dataObject); // Writes til det JSON
            File.WriteAllText(newJsonFilePath, jsonStringWrite); // Writes til det JSON
            Debug.log("datasheet has been writen to '" + newJsonFilePath + "'."); // Logs the File Path
        }
        runTime + 1; // Adds til det RunTime
        // end of Start Checks ; Gathers new Info.
        string jsonStringRead = File.ReadAllText(newJsonFilePath); // Recieves the Json Data
        var dataObject = JsonSerializer.Deserialize<dataObject>(jsonStringRead); // Decodes the JSon Data into a c# obj;
        int recievedDateTime = dataObject.writeDateTime; // Converts Date til en int
        int recievedRunTime = dataObject.openCount; // recieves Previous runTime;
        // Recieves Date Modified with Time
        DateTime lastEdit = File.GetLastWriteTime(gameFiles); // Recieves Last Edit Time
        int modifiedTime = lastEdit; // Assigns Int;

        // Comparisons

        if (modifiedTime =! WriteDateTimer) // Error Data;
        {
            SceneManager.LoadScene("moddingDetected"); // Loads Error Code One
        }
        if (modifiedTime == WriteDateTimer) // Correct Info;
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads next Scene in the Index.
        }
        else // No Data
        {
            Debug.log("Error Code: null"); // Logs the Error Data
            SceneManager.LoadScene("errorCode_2"); // Error Code 2: "Could not load the Necessary Datasets."
        }
    }
}
