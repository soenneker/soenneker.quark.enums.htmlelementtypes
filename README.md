[![](https://img.shields.io/nuget/v/soenneker.quark.enums.htmlelementtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.htmlelementtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.htmlelementtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.htmlelementtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.htmlelementtypes/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.htmlelementtypes/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.htmlelementtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.htmlelementtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.htmlelementtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.htmlelementtypes/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.HtmlElementTypes

Strongly typed HTML element names for dynamic Quark component rendering.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.HtmlElementTypes
```

## Usage

```csharp
HtmlElementType element = HtmlElementType.Section;
string tagName = element.Value; // "section"
```

Use the values when an API needs to select an element at runtime while keeping known tag names discoverable and typo-free. The set covers document metadata, sectioning, text, embedded content, tables, forms, and interactive elements.

Common choices include:

```csharp
HtmlElementType.Div
HtmlElementType.Span
HtmlElementType.Button
HtmlElementType.Input
HtmlElementType.A
HtmlElementType.Img
HtmlElementType.Table
HtmlElementType.Dialog
```

`HtmlElementType` supplies tag names only. It does not render markup or validate which attributes and children are legal for a selected element.
