# Asset Insights c# Stations Test

## Task

## To Run the Program:

Checkout the repo to your local machine.  In your IDE of choice (I used JetBrains Rider on MacBook Pro) run the project.  The config is set to use Http only at this point, using port :5000.  This would need to be changed to use Https if the app was required to run in a Production environment.  This is because SSL certificates would need to be installed for security reasons.  

Running the project will spin up a browser window with the url http://localhost:5000/api/stations, as set in launchsettings.json.  To view details of an individual station name, amend the end of the url, e.g. api/station/Southern Ave (including any spaces within the station name).  Let me point out the need to remove the 's' from the initial url api/station**s**.

Alternatively, you can use an Api Client such as Postman.  If you run the application locally, as above, open Postman -> Create New -> Http Request, set the HTTP verb to Get, paste the same url (http://localhost:5000/api/stations) and hit Send.  The resulting Json will be visible in the lower panel.

## Refactoring Process

I started off by performing some minor refactoring of namespaces, and capitalized methods etc.  Then I started thinking about how to represent the GeoJson as objects in C#.  I briefly thought about using nested Dictionaries, then quickly realised that would make things extremely complicated.  So I decided to create some domain objects (Data Transfer Objects) to represent sections of the Json.

As I was writing the StationsService.cs methods, I realised I had initially made the Dto's way to complex / nested.  So I refactored again to simplify things, fixing the Service and Controller to match.

I realise I should have written the test code first, but old habits took over and I ended up writing the tests at the end.

## Next Steps

To further develop the project, I would begin by setting up the SSL certificates to configure a more secure endpoint.  I would install something like Swagger as an easy way to be able to visualise the results of hitting the endpoints.  I would also add some integration testing by Mocking ( using Moq; ) out the Service and the Controller.
