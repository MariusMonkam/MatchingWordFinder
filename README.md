
```markdown
# MatchingWordFinder API

The MatchingWordFinder API provides search functionality to find matching words within a paragraph. It allows users to submit a paragraph and a search input, and it returns the position and count of matching words in the paragraph.

## Getting Started

These instructions will help you set up and use the MatchingWordFinder API.

### Prerequisites

- .NET Core SDK (version X.X.X)
- Your favorite code editor

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/matchingwordfinder-api.git
   ```

2. Open the project in your code editor.

3. Build the project:

   ```bash
   dotnet build
   ```

4. Run the API:

   ```bash
   dotnet run
   ```

   The API will start running on `https://localhost:5001`.

### Usage

Send a POST request to the `/search` endpoint with the following payload:

```json
{
  "Paragraph": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et lectus sit amet mi facilisis facilisis. Vivamus pretium, tortor id aliquam accumsan, velit ipsum bibendum mi, sed congue risus tellus sed mi. Curabitur at mi ac lacus auctor aliquam a sed ipsum. Integer ac lacus eu urna sollicitudin hendrerit vitae ut ex. Integer rhoncus augue in libero bibendum, ac rhoncus elit faucibus. Sed consectetur arcu sed risus egestas facilisis. Aliquam ut cursus tortor, vel rutrum velit. Nulla facilisi. Etiam fringilla ex ac ligula fermentum ultrices. Cras malesuada nisi eu ipsum consectetur, in fermentum elit eleifend. Nulla facilisi. Nam efficitur placerat nunc id dictum.",
  "SearchInput": "sed"
}

```

#### Request

- `paragraph`: The paragraph to search within (string)
- `searchInput`: The word to search for within the paragraph (string)

#### Response

If matching words are found:

```json
{
  "matchingWords": [
    {
      "word": "ipsum",
      "position": 1
    }
  ],
  "count": 1,
  "highlightedParagraph": "Lorem **ipsum** dolor sit amet, consectetur adipiscing elit."
}
```

If no matching words are found:

```json
{
  "message": "No matching word"
}
```

### Contributing

Contributions are welcome! If you have any suggestions, bug reports, or feature requests, please open an issue or submit a pull request.

### License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

### Acknowledgements

- List any acknowledgements or credits for libraries, frameworks, or resources used in the project.

```

Please make sure to replace "your-username" in the repository URL with your actual GitHub username.

Feel free to customize the content further based on your project's specific details and requirements.

If you have any more questions or need additional assistance, feel free to ask!

Marius Monkam
mariusriusmonkam@yahoo.fr
