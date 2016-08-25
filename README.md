# CourseApi
REST Api for teaching purposes

This application uses .NET Core.

## How to run

* Clone the project (to some location which makes sense)
* Open the /src folder in terminal, cmd or bash
* Insert command 'dotnet restore'
* Open the /CourseApi in the /src folder
* Insert command 'dotnet run'

Now the API is up and running on http://localhost:5000 and the route of the api is located at http://localhost:5000/api/v1/courses

Available resources are:
  * http://localhost:5000/api/v1/courses -> Gets all courses [HttpGet]
  * http://localhost:5000/api/v1/courses/{id} -> Gets a specific course [HttpGet]
  * http://localhost:5000/api/v1/courses -> Creates a new course [HttpPost] 
    - Course is in format { "name": "someName", "templateId": "someTemplateId", "startDate": "22-08-1999", "endDate": "22-12-1999" }
  * http://localhost:5000/api/v1/courses/{id} -> Updates a specific course [HttpPut]
  * http://localhost:5000/api/v1/courses/{id} -> Deletes a specific course [HttpDelete]
  * http://localhost:5000/api/v1/courses/{id}/students -> Gets all students for a specific course [HttpGet]
  * http://localhost:5000/api/v1/courses/{id}/students -> Creates a new student in a specific course [HttpPost]
    - Student is in format { "ssn": "1208931269", "name": "someName" }
