using System.ComponentModel.DataAnnotations;

namespace HelloWorldApi.Requests;

public record GreetingRequest(
    [Required(ErrorMessage = "The 'name' field is required.")]
    [MinLength(1, ErrorMessage = "The 'name' field cannot be empty.")]
    string Name
);