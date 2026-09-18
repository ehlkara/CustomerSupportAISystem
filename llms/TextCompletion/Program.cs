using System.ClientModel;
using Microsoft.Extensions.AI;
using OpenAI;

var options = new OpenAIClientOptions()
{
    Endpoint = new Uri("http://localhost:11434/v1/")
};

IChatClient chatClient = new OpenAIClient(new ApiKeyCredential("ollama"), options).GetChatClient("llama3.1:8b").AsIChatClient();


string prompt = "What is AI ? explain max 20 words";
Console.WriteLine($"User: {prompt}");
ChatResponse response = await chatClient.GetResponseAsync(prompt);

Console.WriteLine($"Assistant: {response}");
Console.WriteLine($"Tokens used in={response.Usage?.InputTokenCount}, out={response.Usage?.OutputTokenCount}");