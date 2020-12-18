using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        public IJSRuntime JS { get; set; }
        [CascadingParameter]
        public string Color { get; set; }

        private int currentCount = 0;
        private static int count = 0;

        [JSInvokable]
        public void IncrementCount()
        {
            currentCount++;
            count++;
            JS.InvokeVoidAsync("dotnetStaticInvokation");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(count);
        }
    }
}
