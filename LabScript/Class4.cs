using LabScript.Pages;
using static System.Runtime.InteropServices.JavaScript.JSType;

@page "/"

@inject IJSRuntime ijsRuntime;
@inject IAlertService alertService;

< PageTitle > Home </ PageTitle >

< h1 > Hello, world! </ h1 >

Welcome to your new app.


< script >

function jsFuncion() {
    alert("Prueba");
}
</ script >

@code{


    protected override async Task OnAfterRenderAsync(bool firstRender)
{
    if (firstRender)
    {
        // await ijsRuntime.InvokeVoidAsync("alert","Prueba");
        await alertService.CallJsAlertFunction();
    }


}
