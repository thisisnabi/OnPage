# OnPage package

**Using .NET CLI (Command Line)**

To download `OnPage`, you can click here: [Nuget](https://www.nuget.org/packages/OnPage/)

## Introduction

Pagination is a common technique used to divide large datasets into smaller, manageable parts known as "pages." This allows for more efficient data retrieval and presentation, especially when dealing with large collections of data. In this NuGet project, we will implement pagination methods to help developers paginate their data effectively.

## Methods

### `Page(index, size)`

This method allows you to retrieve a specific page of data from the dataset based on the provided `index` and `size` parameters.

Parameters:
- `index` (int): The index of the page to retrieve. Page indexing starts from 1.
- `size` (int): The number of items to display per page.

Example:

```csharp
// Assuming you have a list of items named 'dataList'
int pageIndex = 2;
int pageSize = 10;

var pageItems = dataList.Page(pageIndex, pageSize);
// 'pageItems' will contain the items for the second page with 10 items per page.


### `FirstPage(size)`

This method allows you to retrieve a first page of data from the dataset based on the provided `size` parameters.

Parameters:
- `size` (int): The number of items to display per page.

Example:

```csharp
// Assuming you have a list of items named 'dataList'
int pageSize = 10;

var pageItems = dataList.FirstPage(pageSize);
// 'pageItems' will contain the items for the first page with 10 items per page.



### `LastPage(size)`

This method allows you to retrieve a last page of data from the dataset based on the provided `size` parameters.

Parameters:
- `size` (int): The number of items to display per page.

Example:

```csharp
// Assuming you have a list of items named 'dataList'
int pageSize = 10;

var pageItems = dataList.LastPage(pageSize);
// 'pageItems' will contain the items for the first page with 10 items per page.


### `CountOfPage(size)`

This method allows you to retrieve a count of pages of data from the dataset based on the provided `size` parameters.

Parameters:
- `size` (int): The number of items to display per page.

Example:

```csharp
// Assuming you have a list of items named 'dataList'
int pageSize = 10;

var pageCount = dataList.CountOfPages(pageSize);
// 'pageCount' will contain the count of pages of dataList
