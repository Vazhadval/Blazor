
function myFunction(message) {
    console.log("from js file: " + message);
}

function dotnetStaticInvokation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript: " + result);
        });
}

function dotnetInstanseInvokation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}