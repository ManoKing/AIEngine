using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System.Text;

namespace AICommand {

static class OpenAIUtil
{
    static string CreateChatRequestBody(string prompt)
    {
        var msg = new OpenAI.RequestMessage();
        msg.role = "user";
        msg.content = prompt;

        var req = new OpenAI.Request();
        req.model = "gpt-3.5-turbo";
        req.messages = new [] { msg };

        return JsonUtility.ToJson(req);
    }

    public static string InvokeChat(string prompt)
    {
        var settings = AICommandSettings.instance;

        // POST
        //using var post = UnityWebRequest.Post(OpenAI.Api.Url, CreateChatRequestBody(prompt), "application/json");
        using var post = UnityWebRequest.Post(OpenAI.Api.Url, CreateChatRequestBody(prompt));
        post.SetRequestHeader("Content-Type", "application/json");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(CreateChatRequestBody(prompt));
        post.uploadHandler = new UploadHandlerRaw(bodyRaw);
        // Request timeout setting
        post.timeout = settings.timeout;

        // API key authorization
        post.SetRequestHeader("Authorization", "Bearer " + settings.apiKey);

        // Request start
        var req = post.SendWebRequest();

        // Progress bar (Totally fake! Don't try this at home.)
        for (var progress = 0.0f; !req.isDone; progress += 0.01f)
        {
            EditorUtility.DisplayProgressBar
              ("AI Command", "Generating...", progress);
            System.Threading.Thread.Sleep(100);
            progress += 0.01f;
        }
        EditorUtility.ClearProgressBar();

        // Response extraction
        var json = post.downloadHandler.text;
        var data = JsonUtility.FromJson<OpenAI.Response>(json);
        return data.choices[0].message.content;
    }
}

} // namespace AICommand
