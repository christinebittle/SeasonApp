# SeasonApp

This application will take an input of the temperature and output a webpage associated with the season.

Key Files in this Project:

- Models/Season.cs. A class which holds information about a season, including the season name and associated image.
- Controllers/SeasonAPIController.cs. The main logic webapi controller. Inputs a temperature and outputs a season object.
- Controllers/SeasonController.cs. Controller which connects to views. Receives temperature data and presents a webpage for the season.
- Views/Season/Index.cshtml. A view which creates a webpage that asks the user for the temperature.
- Views/Season/Show.cshtml. A view which creates a webpage that shows the season image and season name. 
- Views/Shared/\_Layout.cshtml. A special view which describes a general header HTML and footer HTML. 

![Diagram Depicting the flow of information](https://github.com/christinebittle/SeasonApp/blob/master/SeasonApp/Content/images/server_rendered_pages.png)

[Client side codebase for accessing this webapi method can be found here](https://github.com/christinebittle/seasonapp_xhr)
