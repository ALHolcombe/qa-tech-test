
Run testRunner.CMD to run test via .netCore CLI. 

Alternatively, open solution and run the unit tests via Visual Studio. 

Please note, I've not really used docker before - my test framework will spin up a container, 
run tests against the web app and then attempt to stop/remove the container - but i'm aware it's quite flakey. 

If the docker stuff isn't working - remove the [BeforeTestRun] and [AfterTestRun] steps in the Hooks.cs file.

Look forward to hearing from you!

Adam
