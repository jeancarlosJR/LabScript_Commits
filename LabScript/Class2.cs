﻿using System.Runtime.Serialization;

@page "/counter"

<PageTitle>Counter</PageTitle>

@implements IAsyncDisposable
@inject IJSRuntime ijsRuntime

<h1>Counter</h1>

<p role="status">Current count: @currentCount </ p >

< button class= "btn btn-primary" @onclick = "IncrementCount" > Click me </ button >

< button class= "btn btn-primary" @onclick = "ShowMessage" > Mostrar Mensaje </ button >

@code {
    private int currentCount = 0;

private IJSObjectReference module;

protected override async Task OnAfterRenderAsync(bool firstrender)
{
    if (firstrender)
    {
        module = await ijRuntime.InvokeAsync<IJSObjectReference>("import",
        "./Pages/Counter.razor.js");
    }
}

private async void ShowMessage()
{
    if (module != null)
    {
        await module.InvokeVoidAsync("Alert");
    }
}
private void IncrementCount()
{
    currentCount++;
}

async ValueTask IAsyncDisposable.DisposeAsycn()
{
    if (module != null) await module.DisposeAsync();
}

}
