namespace Smdb.Api.Movies;

using Shared.Http;

public class MoviesRouter : HttpRouter
{
	public MoviesRouter(MoviesController moviesController)
	{
		UseParametrizedRouteMatching();
		// Get /api/v1/movies/
		MapGet("/", moviesController.ReadMovies);
		// Post /api/v1/movies/
		MapPost("/", HttpUtils.ReadRequestBodyAsText, moviesController.CreateMovie);
		// Get /api/v1/movies/{id}
		MapGet("/:id", moviesController.ReadMovie);
		// Put /api/v1/movies/{id}
		MapPut("/:id", HttpUtils.ReadRequestBodyAsText, moviesController.UpdateMovie);
		// Delete /api/v1/movies/{id}
		MapDelete("/:id", moviesController.DeleteMovie);
	}
}
