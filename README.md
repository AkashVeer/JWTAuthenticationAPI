# JWTAuthenticationAPI
.Net Core 3.1 API authentication using JWT

Running the ASP.NET Core JWT Authentication API Locally

1. Download or clone the tutorial project code from https://github.com/AkashVeer/JWTAuthenticationAPI
2. Start the api by running dotnet run from the command line in the project root folder.

Authenticate user with Postman

1. Open a new request tab.
2. Change the http request method to "POST" with the dropdown selector on the left of the URL input field.
3. In the URL field enter the address to the authenticate route of your local API - https://localhost:5001/users/authenticate.
4. Select the "Body" tab below the URL field, change the body type radio button to "raw", and change the format dropdown selector to "JSON (application/json)".
5. Enter a JSON object containing the test username and password in the "Body" textarea

{
  "username":"test",
  "password":"test"
}
6. The response will have a bearer token which will be used to authenticate all other API requests. Store the token.

Authenticated request to fetch all users

1. Open a new request tab.
2. Change the http request method to "GET" with the dropdown selector on the left of the URL input field.
3. In the URL field enter the address to the users route of your local API - https://localhost:5001/users.
4. Select the "Authorization" tab below the URL field, change the type to "Bearer Token" in the type dropdown selector, and paste the JWT token from the previous authenticate step into the "Token" field.
5. Click the "Send" button, you should receive a "200 OK" response containing a JSON array with all the user records in the system.
