using System.ClientModel;
using Microsoft.Extensions.AI;
using OpenAI;

var options = new OpenAIClientOptions()
{
    Endpoint = new Uri("http://localhost:11434/v1/")
};

IChatClient chatClient = new OpenAIClient(new ApiKeyCredential("ollama"), options).GetChatClient("llama3.1:8b").AsIChatClient();


ChatResponse response = await chatClient.GetResponseAsync("What is AI ? explain max 20 words");

Console.WriteLine(response);