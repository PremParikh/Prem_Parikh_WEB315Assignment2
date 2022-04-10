Step: Create a Food list Blazor app project
    Modify Razor components
    Use event handling and data binding in components
    Use routing in a Blazor app

1.dotnet new blazorserver -o FoodList

2.cd FoodList

3.dotnet new razorcomponent -n Food -o Pages

4.Open the Food component in any file editor and add an @page Razor directive to the top of the file with a relative URL of /todo.
Pages/Food.razor:

5.Add the Food component to the navigation bar.
The NavMenu component is used in the app's layout. Layouts are components that allow you to avoid duplication of content in an app. The NavLink component provides a cue in the app's UI when the component URL is loaded by the app.
In the unordered list (<ul>...</ul>) of the NavMenu component, add the following list item (<li>...</li>) and NavLink component for the Todo component.
In Shared/NavMenu.razor:

6.Build and run the app by executing the dotnet watch run command in the command shell from the TodoList folder. After the app is running, visit the new Todo page by selecting the Todo link in the app's navigation bar, which loads the page at /todo.
Leave the app running the command shell. Each time a file is saved, the app is automatically rebuilt, and the page in the browser is automatically reloaded.

7.Add a Fooditem.cs file to the root of the project (the FoodList folder) to hold a class that represents a Food item. Use the following C# code for the TodoItem class.
FoodItem.cs:

8.Return to the Food component and perform the following tasks:
Add a field for the Food items in the @code block. The Food component uses this field to maintain the state of the Food list.
Add unordered list markup and a foreach loop to render each Food item as a list item (<li>).
Pages/Food.razor:

9.The app requires UI elements for adding Food items to the list. Add a text input (<input>) and a button (<button>) below the unordered list (<ul>...</ul>):

10.Save the FoodItem.cs file and the updated Pages/Food.razor file. In the command shell, the app is automatically rebuilt when the files are saved. The browser reloads the page.

11.When the Add Food button is selected, nothing happens because an event handler isn't attached to the button.

12.Add an Addfood method to the Food component and register the method for the button using the @onclick attribute. The AddTodo C# method is called when the button is selected:

13.private string newfood;

14.Modify the text <input> element to bind newfood with the @bind attribute
<input placeholder="Something Food" @bind="newfood" />

15.Update the Addfood method to add the foodItem with the specified title to the list. Clear the value of the text 
input by setting newfood to an empty string:

16.Save the Pages/Food.razor file. The app is automatically rebuilt in the command shell, and the page reloads in the browser.

17.The title text for each Food item can be made editable, and a checkbox can help the user keep track of completed items. Add a checkbox input for each todo item and bind its value to the IsDone property. Change @todo.Title to an <input> element bound to todo.Title with @bind:

18.Update the <h1> header to show a count of the number of Food items that aren't complete (IsDone is false).
<h1>Food (@foods.Count(food => !Food.IsDone))</h1>

19.The completed Food component (Pages/Food.razor):

20.Save the Pages/Food.razor file. The app is automatically rebuilt in the command shell, and the page reloads in the browser.

21.Add items, edit items, and mark food items done to test the component.

22.When finished, shut down the app in the command shell. Many command shells accept the keyboard command Ctrl+C (Windows) or ⌘+C (macOS) to stop an app.