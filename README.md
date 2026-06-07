# MovieStream

MovieStream is a movie management web application built with ASP.NET Core MVC and Entity Framework Core. The application allows users to create, view, update, delete, and search movies stored in a SQL Server database.

## Features

* View all movies
* Add new movies
* Edit existing movies
* Delete movies
* View movie details
* Search movies by title
* Display movie posters using image URLs

## Technologies Used

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQL Server
* Razor Views
* Bootstrap

## Project Structure

The application follows the MVC (Model-View-Controller) architectural pattern:

### Models

Contains the Movie model that represents movie data.

### Views

Contains Razor pages responsible for rendering the user interface.

### Controllers

Handles user requests and communication between views and the database.

### Data

Contains the MovieContext class used by Entity Framework Core for database operations.

## Movie Model

The Movie model includes:

* Id
* Title
* Genre
* ReleaseYear
* Rating
* Duration
* PosterUrl
* Description

## CRUD Operations

The application supports full CRUD functionality:

### Create

Add new movies to the database.

### Read

View all movies and individual movie details.

### Update

Edit existing movie information.

### Delete

Remove movies from the database.

## Search Functionality

Users can search for movies by title using a search bar on the main page.

## Database

Entity Framework Core migrations are used to create and manage the SQL Server database schema.

## Future Improvements

* User authentication
* Role-based authorization
* Movie categories
* Responsive Netflix-inspired design
* Movie ratings and reviews
* Pagination

## Author

Riman Farhood
