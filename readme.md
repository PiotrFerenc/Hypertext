# Hypertext Library

## Overview

This project is a lightweight C# library designed to help developers efficiently build structured HTML elements programmatically. It provides an intuitive API for dynamically creating and manipulating HTML components, simplifying the process of working with HTML in .NET applications.

## Features

- **Declarative API for HTML:** Create HTML tags, attributes, and structures programmatically.
- **Support for Common HTML Elements:** Provides handy methods for commonly used tags such as `div`, `span`, `p`, `a`, `ul`, `li`, headings (`h1`-`h6`), images, buttons, and more.
- **Fragment Support:** Combine multiple elements into fragments for flexible and reusable HTML structures.
- **Self-Closing Tags:** Easily create self-closing tags like `<img>` and `<input>` with specific attributes.
- **Custom Attribute Management:** Add attributes to tags to manage styling, interactivity, or other custom properties.


## Example Usage

```csharp
using Hypertext;

var html = Html.Div(
    Html.H1("Welcome to Hypertext Library"),
    Html.P("This is a simple example of dynamically generated HTML."),
    Html.Ul(
        Html.Li(Html.Text("First item")),
        Html.Li(Html.Text("Second item")),
        Html.Li(Html.Text("Third item"))
    ),
    Html.A("https://example.com", Html.Text("Click here to learn more")),
    Html.Img("logo.png", "Company Logo")
);

// Result:
// <div>
//   <h1>Welcome to Hypertext Library</h1>
//   <p>This is a simple example of dynamically generated HTML.</p>
//   <ul>
//     <li>First item</li>
//     <li>Second item</li>
//     <li>Third item</li>
//   </ul>
//   <a href="https://example.com">Click here to learn more</a>
//   <img src="logo.png" alt="Company Logo"/>
// </div>
```



## Benefits

1. **Simplifies HTML Creation**: Reduces boilerplate and avoids manual string-based HTML manipulation.
2. **Improved Code Readability**: Building HTML with structured methods leads to cleaner and easily maintainable code.
3. **Runtime Flexibility**: Dynamically generate HTML content based on the application's logic at runtime.
4. **Reusable Components**: Use fragments and reusable compositions to avoid duplication.

## Contribution

Contributions to the **Hypertext Library** are welcome! Feel free to create issues and submit pull requests to suggest improvements or fix bugs.

---

Thank you for using the Hypertext library! Happy coding! 🎉