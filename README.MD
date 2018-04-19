Toy Robot Simulator
===================
The application is an implementation of the Toy Robot Simulator.


Running the application
-----------
Before running, you need to compile the application from this source. You'll need the [.NET Core command line tool](https://www.microsoft.com/net/download) to compile the application.

```sh
    $ dotnet build
```

- Run the application in your terminal

```sh
    $ cd ToyRobot
    $ dotnet run
```

- You can also run the application to process specified input and output files:

```sh
    $ cd ToyRobot
    $ dotnet run ./test-data/1.txt ./test-data/1.out.txt
```



Using the test data
-----------
Some test data are provided at `ToyRobot/test-data` folder. Feel free to use. You can also copy those content into terminal and play them in an interactive mode.




Using the code
-----------

- The solution project was built based on .NET Core, so please confirm you have .NET Core SDK installed on your computer before you start to work on the code
- The project contains two parts: the `ToyRobot` folder container the main implementation logic and the `ToyRobot.Tests` contains the unit tests.

```sh
    $ cd ToyRobot.Tests
    $ dotnet test
```

Happy coding!

