# TechSupport – WinForms Application

TechSupport is a C# Windows Forms application developed as part of a coursework assignment to demonstrate the use of multiple forms, modal dialogs, and the Model–View–Controller (MVC) pattern with a Data Access Layer (DAL). The application simulates a basic tech support incident management system.

---

## Features

- **Login System**
  - Username and password authentication
  - Case-sensitive login validation
  - Error messages displayed for invalid credentials
  - Error messages automatically clear when the user begins typing again

- **Main Form**
  - Displays the logged-in username
  - Logout functionality to return to the login screen
  - Displays all incidents in a DataGridView
  - Buttons to add and search incidents

- **Add Incident (Modal Form)**
  - Allows users to add a new incident with:
    - Title
    - Description
    - Customer ID (integer)
  - Field-level validation with individual error messages
  - Error messages clear when the user corrects input
  - Modal behavior prevents multiple Add windows from opening

- **Search Incident (Modal Form)**
  - Search incidents by Customer ID
  - Displays search results in a DataGridView on the search form
  - DataGridView is empty when the form initially loads

- **Application Behavior**
  - Forms are centered on the screen
  - Tab order is set for logical keyboard navigation
  - Closing any main window cleanly exits the application (no hidden processes)
