# HelloWorldAPI

## Project Description

---

**HelloWorldAPI** is a simple REST API built in C# using .NET 9.  
The project provides two controllers:

- **HelloWorldController** – returns a basic "Hello, World" message along with the current date.
- **GreetingController** – provides random Norwegian greetings and allows greeting a user by name (GET and POST).

The API is documented using **Scalar.AspNetCore** and all responses are returned in JSON format.

---

## Technologies
- C#
- .NET 9
- Scalar.AspNetCore

---

## How to Run the Project

1. Clone the repository:

```bash
git clone https://github.com/0xkpod/HelloWorldAPI.git
```

2. Go into the directory:

```bash
cd HelloWorldAPI
```

3. Restore dependencies and run the project:

```bash
dotnet restore
dotnet run
```

The API will be available at:
```
http://localhost:PORT/scalar/v1
```

---

## License
This project is open source and free to use in any way.