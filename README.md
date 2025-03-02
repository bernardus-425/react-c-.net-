# Fisher-Yates Shuffle - Technical Assessment

This project implements the Fisher-Yates shuffle algorithm (also known as the Knuth shuffle) as part of a technical assessment. The solution includes a **web application** that exposes the algorithm through an API endpoint and a **unit test project** to validate the correctness of the shuffle implementation.

## Project Overview

This project contains the following components:
- **FisherYatesWebApp**: An ASP.NET Core Web Application that implements the Fisher-Yates shuffle algorithm. The application exposes an endpoint `/fisheryates` where users can send a string of dasherized elements to be shuffled.
- **FisherYatesTests**: A set of unit tests for validating the Fisher-Yates shuffle algorithm. The tests check for correctness, ensuring the shuffled result is random and contains the same elements as the input.

## Task 2: Fisher-Yates Shuffle

### Fisher-Yates Algorithm (Modern Version)

The Fisher-Yates shuffle is a well-known algorithm used for randomly shuffling elements in an array. The modern version of the algorithm, popularized by Donald Knuth, ensures an unbiased shuffle with a time complexity of **O(n)**.

In this implementation, the algorithm works as follows:
1. Given a list of elements, we shuffle the list using a random index generator.
2. The algorithm iterates from the last element of the list to the second element.
3. For each element, a random index is chosen from the remaining unshuffled elements, and the two elements are swapped.

### API Endpoint

The web application exposes the following **GET** API endpoint:

- **`GET /fisheryates`**
  - **Input**: A string of elements separated by hyphens (e.g., `A-B-C-D`).
  - **Output**: A shuffled version of the input string, with elements randomly rearranged, returned as plain text.
  - Example: A request to `/fisheryates?input=A-B-C-D` could return a result like `C-D-B-A`.

### Unit Tests

The unit tests for the Fisher-Yates shuffle algorithm are located in the `FisherYatesTests` project. These tests verify the following:
- The shuffled list contains the same elements as the input.
- The shuffled list is not in the same order as the input (ensuring randomness).
- There are no duplicate elements in the shuffled list.
- The length of the shuffled list matches the input list.

## Setup Instructions

### Prerequisites

To run the application and tests, ensure that the following are installed:
- [.NET SDK 7.0 or later](https://dotnet.microsoft.com/download/dotnet)
- A compatible IDE (e.g., Visual Studio, Visual Studio Code, or JetBrains Rider)

### Running the Web Application

1. Clone or download the repository.
2. Navigate to the `FisherYatesWebApp` folder.
3. Run the application using the following command:

   ```bash
   dotnet run
    ```
4. The web application will start and be accessible at http://localhost:5000 (default for ASP.NET Core apps).
5. To access the Fisher-Yates shuffle endpoint, make a GET request to /fisheryates with a query string parameter input. Example:
    ```bash
    http://localhost:5094/fisheryates?input=A-B-C-D
    ```
    This will return a shuffled version of the input string, like:
    ```bash
    D-B-A-C
    ```

### Running Unit Tests

1. Navigate to the FisherYatesTests folder.
2. Run the unit tests using the following command:
    ```bash
    dotnet test
    ```

### Notes
- The Fisher-Yates algorithm implementation in this project is designed for randomness and correctness.
- The unit tests ensure that the shuffle works as expected, even though the results will differ with each execution due to the randomness involved.

