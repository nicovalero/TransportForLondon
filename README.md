**How to build the code**
The easiest way to build to code is to **open the solution in Visual Studio**. For this project I used Visual Studio 2019, Community Version.
Once the solution is open, it can be built by click on **Debug > Build Solution** or its shortcut **Ctrl + Alt + B**.

**How to run the output**
The application runs by pressing the **play button** at the upper-middle side in Visual Studio, or by pressing **F5**.
A Console/Terminal will appear with a few instructions to interact with the application. These instructions are:
    - Type **"exit" to exit the application**.
    - Type **any other string to call the API** to retrieve information.
When trying to obtain some information, the application may respond with two different answers:
    - **The road exists**, hence the **information appears in the console**. After this action, the user may type more roads to keep retrieving information.
    - The road **doesn't exist** in the API, then the application will **show a message** and will **terminate its run with a code 1**.

**How to run the tests**
The easiest way to run the tests is:
    - Clicking on **Test > Run All Tests**. The **Test Explorer should appear** with information about the test run.
    - Alternatively, under the project TflConsoleApp.Tests, you can find the classes with tests inside. **You can trigger the tests by going to each method > right click on the name > Run Test**.

**Assumptions I have made**
The only assumption I made was that I can retrieve information about roads by calling https://api.tfl.gov.uk/Road/<name of the road>.
Also I assumed the information returned, if the road exists, has got the same properties as given in the document. Any others would be ignored.

**Relevant information**
Followed SOLID principles mainly. Tests are done by the fake technique.