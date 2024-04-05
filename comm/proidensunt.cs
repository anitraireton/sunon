// Get the file extension of the specified commit file.
string GetFileExtension(string filePath)
{
    // Check if the file path is null or empty.
    if (string.IsNullOrEmpty(filePath))
    {
        throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
    }

    // Extract the extension from the file path.
    string extension = Path.GetExtension(filePath);

    // Check if the extension was successfully retrieved.
    if (string.IsNullOrEmpty(extension))
    {
        throw new InvalidOperationException("Unable to retrieve the file extension.");
    }

    // Return the file extension in lowercase for consistency.
    return extension.ToLowerInvariant();
}

// Usage example:
// Assuming 'commitFile' is a variable containing the file path.
string commitFile = "example.txt";
string extension = GetFileExtension(commitFile);
